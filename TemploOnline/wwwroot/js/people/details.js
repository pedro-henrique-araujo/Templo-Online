$(document).ready(function () {
  var btnDelete = $("#btn-delete")
  $(btnDelete).on("click", function () {
    bootbox.confirm(deleteBootBox(function (result) {
      if (result) {
        $.ajax({
          url: `/api/people/${$(btnDelete).attr("data-person-id")}`,
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

  var btnResetPwd = $("#btn-reset-pwd")
  $(btnResetPwd).on("click", function () {
    bootbox.confirm(confirmBootBox(function (result) {
      if (result) {
        $.ajax({
          url: `/api/people/ ${$(btnResetPwd).attr("data-person-id")}`,
          method: "PUT",
          success: function (result) {
            resultMessageBox(result, false)
          },
          error: function (result) {
            resultMessageBox(result.responseJSON, false)
          }
        })
      }
    }))
  })

  function resultMessageBox(resultMessage, gotToIndex = true)
  {
    var { title, message } = resultMessage
    bootbox.alert({
      title: title,
      message: message,
      callback: function () {
        if (gotToIndex)
          $(location).attr("href", "/People")
      }
    })   
  }

  function confirmBootBoxTemp(callbackFunction) {
    return {
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

  function deleteBootBox(callbackFunction) {
    return {
      title: "Remover irmão",
      message: "Deseja remover este irmão?",
      ...confirmBootBoxTemp(callbackFunction)
    }
  }

  function confirmBootBox(callbackFunction) {
    return {
      title: "Resetar senha",
      message: "Deseja resetar a senha?",
      ...confirmBootBoxTemp(callbackFunction)
    }
  }
})