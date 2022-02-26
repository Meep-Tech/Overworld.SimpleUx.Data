using Meep.Tech.Collections.Generic;
using System;
using System.Collections.Generic;

namespace Simple.Ux.Data.Unity {

  /// <summary>
  /// Overworld specific display types.
  /// </summary>
  public class DisplayType : DataField.DisplayType {

    /// <summary>
    /// A set of modular overworld executables.
    /// </summary>
    public static DisplayType Executeable {
      get;
    } = new DisplayType(nameof(Executeable), (
      string title,
      string tooltip,
      object value,
      bool isReadOnly,
      string dataKey,
      DelegateCollection<Func<DataField, View, bool>> enabledIf,
      DelegateCollection<Func<DataField, View, bool>> hiddenIf,
      DelegateCollection<Func<DataField, object, (bool success, string message)>> validations,
      DelegateCollection<Action<DataField, object>> onValueChanged,
      Dictionary<Type, Attribute> attributes
    ) => {
      throw new System.NotImplementedException();
    }, typeof(Overworld.Data.Executeable).AsSingleItemEnumerable());

    protected DisplayType(string nameId, DefaultFieldConstructor defaultFieldConstructor, IEnumerable<Type> defaultFieldTypes = null) 
      : base(nameId, defaultFieldConstructor, defaultFieldTypes) {}
  }
}