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

  var btnAddTeacher = $("#btn-add-teacher")
  $(btnAddTeacher).on("click", function () {
    $("#modal-new-teacher").modal("show")
    var classroomId = $(btnAddTeacher).attr("data-classroom-id")
    $.ajax({
      method: "GET",
      url: `/api/people/true/${classroomId}`,
      success: function (result) {
        $(result).each((index, value) => {
          var { id, nickname } = value
          $("#select-teachers").append(`<option value="${id}">${nickname}</option>`)
        })
      }
    })
  })

  var btnSavePersonClassroom = $("#btn-save-person-classroom")
  $(btnSavePersonClassroom).on("click", function () {
    var personId = $("#select-teachers option[selected]").val()
    $.ajax({
      method: "POST",
      url: "/api/people",
      contentType: "application/json",
      data: {
        personId,
        classroomId: $(btnAddTeacher).attr("data-classroom-id"),
        asTeacher: true
      }
    })
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