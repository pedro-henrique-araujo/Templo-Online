$(document).ready(function () {
  var btnDelete = $("#btn-delete")
  $(btnDelete).on("click", function () {
    bootbox.confirm(deleteBootBox(function (result) {
      if (result) {  
        $.ajax({
          url: `/api/categories/${$(btnDelete).attr("data-category-id")}`,
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
    var {title, message} = resultMessage
    bootbox.alert({
      title: title,
      message: message
    })
    $(location).attr("href", "/Categories")
  }

  function deleteBootBox(callbackFunction) {
    return {
      title: "Remover categoria",
      message: "Deseja remover esta categoria?",
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