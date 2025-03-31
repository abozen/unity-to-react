mergeInto(LibraryManager.library, {
  myJavaScriptFunction: function(message) {
    // index.html'de tanımlı olan metodu çağır
    window.myJavaScriptFunction(UTF8ToString(message));
  },
});