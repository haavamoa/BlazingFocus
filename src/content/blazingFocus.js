// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.blazingFocus = {
  focusElement: function (id) {
    var element = document.getElementById(id);
    element.focus();
    return (document.activeElement === element);
  }
};
