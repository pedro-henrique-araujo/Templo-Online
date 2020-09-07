$(document).ready(function () {
  var btnDelete = $("#btn-delete")
  $(btnDelete).on("click", function () {
    bootbox.confirm(deleteBootBox(function (result) {
      if (result) {
        $.ajax({
          url: `/api/roles/${$(btnDelete).attr("data-role-id")}`,
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
    var { title, message } = resultMessage
    bootbox.alert({
      title: title,
      message: message
    })
    $(location).attr("href", "/Roles")
  }

  function deleteBootBox(callbackFunction) {
    return {
      title: "Remover permissão",
      message: "Deseja remover esta permissão?",
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