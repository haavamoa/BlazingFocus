// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.blazingFocus = {
    hasElementFocus: function (element) {
        return (document.activeElement === element);
    },

  focusElement: function (element) {
    element.focus();
      return (document.activeElement === element);
    },

  blurElement: function(element) {
      element.blur();
      return (document.activeElement !== element);
    }
};
