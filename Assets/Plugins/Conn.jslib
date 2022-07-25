mergeInto(LibraryManager.library, {

  JoinRoomWRTC: function (str) {
    var e = new CustomEvent("join-room", { detail: str });
    window.dispatchEvent(e);
  },
  
  LeaveRoomWRTC: function () {
    var e = new CustomEvent("leave-room");
    window.dispatchEvent(e);
  }

});
