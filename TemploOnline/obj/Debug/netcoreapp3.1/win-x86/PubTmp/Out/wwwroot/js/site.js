$(document).ready(function () {
  $("input").attr("autocomplete", "off")

  var hiddenNav = $("#hidden-nav")
  $("#nav-hide").click(() => {
    $(hiddenNav).animate({ left: "-300px" })
  })
  
  $("body").on("swipeleft", () => $(hiddenNav).animate({ left: "-300px" }))

  $("#nav-show").click(() => {
    $(hiddenNav).animate({ left: "0px"})
  })
  
})