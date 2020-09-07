$(document).ready(function () {
  var btnDelete = $("#btn-delete")
  $(btnDelete).on("click", function () {
    bootbox.confirm(deleteBootBox(function (result) {
      if (result) {
        $.ajax({
          url: `/api/textbooks/${$(btnDelete).attr("data-textbook-id")}`,
          method: "DELETE",
          success: function (result) {
            resultMessageBox(result)
          },
          error: function (result) {
            resultMessageBox(result.responseJSON)
          }
        })
      }
    }))
  })

  function resultMessageBox(resultMessage) {
    var {title, message}  = resultMessage
    bootbox.alert({
      title: title,
      message: message
    })
    $(location).attr("href", "/TextBooks")
  }

  function deleteBootBox(callbackFunction){
    return {
      title: "Remover revista",
      message: "Deseja remover esta revista?",
      buttons: {
        confirm: {
          label: "Sim",
          className: "btn btn-primary"
        },
        cancel: {
          label: "Não",
          className: "btn bg-light"
        }
      },
      callback: callbackFunction
    }
  }
})