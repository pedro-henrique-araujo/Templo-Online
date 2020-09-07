$(document).ready(function () {
  var btnDelete = $("#btn-delete")
  $(btnDelete).on("click", function () {
    bootbox.confirm(deleteBootBox(function (result) {
      if (result) {
        $.ajax({
          url: `/api/classrooms/${$(btnDelete).attr("data-classroom-id")}`,
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
    $(location).attr("href", "/Classrooms")
  }

  function deleteBootBox(callbackFunction) {
    return {
      title: "Remover sala",
      message: "Deseja remover esta sala de aula?",
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