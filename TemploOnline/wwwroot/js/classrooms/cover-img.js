$(document).ready(function () {
  var modal = $("#modal")
  var imgSelector = $("#img-selector")
  var page = 1
  $("#btn-cover").click(searchImgs)
  $("#btn-search").click(searchImgs)
  $("#btn-more").click(e => searchImgs(e, true))
  $("#close-btn").click(e => {
    e.preventDefault()
    $(modal).modal("hide")
  })

  function searchImgs(e, more = false) {
    e.preventDefault()
    $(modal).modal('show')
    var q = encodeURIComponent($("#input-search").val())
    if (more) {
      page++
    } else {
      $(imgSelector).html("")
      page = 1
    }
    var url = 
      "https://pixabay.com/api/?key=yourkey&safesearch=true&q=" + q + "&page=" + page   
     
    $.get(url, handleResult)
   }

  function handleResult(result) {    
    $(result.hits).each(function (i, v) {
      var selector = createSelectorElement(v.largeImageURL)
      $(imgSelector).append(selector)
    })
  }

  function createSelectorElement(src) {
    var img = document.createElement("img")    
    $(img).attr("src", src).attr(getImgAttrs())
    $(img).css(getImgCss())
    $(img).click(imgClickEvent)
    return img
  }

  function imgClickEvent(e) {
    $(modal).modal('hide')
    var src = $(e.target).attr("src")
    $("#cover-img").attr({ src })
    $("#cover-img-input").val(src)
  }

  function getImgAttrs() {
    return {
      "class": "col-md-6 col-sm-12 p-3"
    }
  }

  function getImgCss() {
    return {
      cursor: "pointer"
    }
  }
})