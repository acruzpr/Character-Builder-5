﻿using System;

using CB_5e.Models;
using CB_5e.ViewModels;

using Xamarin.Forms;
using CB_5e.Services;
using Character_Builder;
using System.Collections.Generic;
using PCLStorage;
using System.IO;
using System.Threading.Tasks;
using PluginDMG;

namespace CB_5e.Views
{
    public partial class CharactersPlayPage : ContentPage
    {
        CharactersViewModel viewModel;

        public CharactersPlayPage()
        {
            InitializeComponent();

            BindingContext = viewModel = CharactersViewModel.Instance;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (IsBusy) return;
            IsBusy = true;
            viewModel.Items.Clear();
            var item = args.SelectedItem as Character;
            if (item == null)
                return;
            BuilderContext Context = new BuilderContext(item.Player);
            PluginManager manager = new PluginManager();
            manager.plugins.Add(new SpellPoints());
            manager.plugins.Add(new SingleLanguage());
            Context.Plugins = manager;

            if (App.AutoSaveDuringPlay)
            {
                Task.Run(async () =>
                {
                    if (Context.Player.FilePath is IFile file)
                    {
                        string name = file.Name;
                        IFile target = await (await App.Storage.CreateFolderAsync("Backups", CreationCollisionOption.OpenIfExists).ConfigureAwait(false)).CreateFileAsync(name, CreationCollisionOption.ReplaceExisting).ConfigureAwait(false);
                        using (Stream fout = await target.OpenAsync(FileAccess.ReadAndWrite))
                        {
                            using (Stream fin = await file.OpenAsync(FileAccess.Read))
                            {
                                await fin.CopyToAsync(fout);
                            }
                        };
                    }
                }).Forget();
            }
            Context.UndoBuffer = new LinkedList<Player>();
            Context.RedoBuffer = new LinkedList<Player>();
            Context.UnsavedChanges = 0;
            ItemsListView.SelectedItem = null;
            LoadingProgress loader = new LoadingProgress(Context);
            LoadingPage l = new LoadingPage(loader);
            await Navigation.PushModalAsync(l);
            var t = l.Cancel.Token;
            try
            {
                await loader.Load(t).ConfigureAwait(false);
                t.ThrowIfCancellationRequested();
                PlayerViewModel model = new PlayerViewModel(Context);
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopModalAsync(false);
                    await Navigation.PushModalAsync(new PlayPage(model));
                });
            }
            catch (OperationCanceledException) {
                CharactersViewModel.Instance.LoadItemsCommand.Execute(null);
            }
            finally
            {
                IsBusy = false;
            }
            // Manually deselect item

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
