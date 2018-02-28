﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Sdl.Community.AhkPlugin.Annotations;
using Sdl.Community.AhkPlugin.Helpers;
using Sdl.Community.AhkPlugin.ItemTemplates;
using Sdl.Community.AhkPlugin.Model;
using Sdl.Community.AhkPlugin.Ui;

namespace Sdl.Community.AhkPlugin.ViewModels
{
	public class ScriptsWindowViewModel: ViewModelBase
	{
		private readonly MainWindowViewModel _mainWindow;
		private ObservableCollection<ScriptsDataGridItemTemplate> _scriptsCollection = new ObservableCollection<ScriptsDataGridItemTemplate>();
		private ICommand _addCommand;
		private ICommand _importCommand;
	
		public ScriptsWindowViewModel(MainWindowViewModel mainWindowViewModel)
		{
			_mainWindow = mainWindowViewModel;
			var scripts = new List<Script>
			{
				new Script
				{
					Name = "Script1",
					Description = "dasdasdadsa"
				},
				new Script
				{
					Name = "Script2",
					Description = "oodoasdasda"
				}
				,
				new Script
				{
					Name = "Script3",
					Description = "oodoasdasda"
				},
				new Script
				{
					Name = "aaa",
					Description = "oodoasdasda"
				},
				new Script
				{
					Name = "bbbb",
					Description = "oodoasdasda"
				}
			};
			foreach (var script in scripts)
			{
				var scriptTemplate = new ScriptsDataGridItemTemplate
				{
					Description = script.Description,
					Name = script.Name
				};
				ScriptsCollection.Add(scriptTemplate);
			}
		}

		public ICommand AddCommand => _addCommand ?? (_addCommand = new CommandHandler(AddScriptAction, true));
		public ICommand ImportCommand => _importCommand ?? (_importCommand = new CommandHandler(ImportAction, true));
		private void AddScriptAction()
		{
			_mainWindow.LoadAddScriptPage();
		}

		private void ImportAction()
		{
			_mainWindow.LoadImportPage();
		}
		public ObservableCollection<ScriptsDataGridItemTemplate> ScriptsCollection
		{
			get => _scriptsCollection;

			set
			{
				if (Equals(value, _scriptsCollection))
				{
					return;
				}
				_scriptsCollection = value;
				OnPropertyChanged(nameof(ScriptsCollection));
			}
		}
	}
}
