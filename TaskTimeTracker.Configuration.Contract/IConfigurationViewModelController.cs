﻿using System.Windows;
using System.Windows.Input;

namespace TaskTimeTracker.Configuration.Contract {
  public interface IConfigurationViewModelController {

    Window Window { get; }

    void SetKey(Key key, IConfigurationWindowViewModel viewModel);

    void ExecuteCancel(object obj);

    void ExecuteOk(object obj);

    /// <summary>
    /// Creates a ViewModel from a Configuration
    /// </summary>
    /// <param name="configuration"></param>
    /// <returns></returns>
    IConfigurationWindowViewModel FromConfiguration(ITaskTimeTrackerConfiguration configuration);
  }
}