mergeInto(LibraryManager.library, {

  JoinRoomWRTC: function (str) {
    var x = new CustomEvent("join-room", { detail: str });
    window.dispatchEvent(x)
  },

});