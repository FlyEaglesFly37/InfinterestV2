// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function(){
  $(".fa-chevron-down").on('click', function (event) {
      $('html, body').animate({
          scrollTop: 725
      }, 'slow');
  });
  $(".login").click(function(){
    $(".loginbox").animate({
    left: "-=35%"
  }, 1000, function() {
      
    });
  });
  $(".fa-times-circle").click(function(){
    $(".loginbox").animate({
    left: "+=20%"
  }, 1000, function() {
    
    });
  });
  $(".whitelogo").hover(function () {
      $('.whitelogo').attr("src", "../images/blue-nosub-inflogo.png");
  }, function () {
      $('.whitelogo').attr("src", "../images/white-nosub-inflogo.png");
  });
  $(".favBut").click(function () {
    $(".glyphicon-heart").addClass('red');
  })
  
});

var otherCheckbox = document.querySelector('input[value="other"]');
var otherText = document.querySelector('input[id="otherValue"]');
otherText.style.visibility = 'hidden';

otherCheckbox.onchange = function() {
  if(otherCheckbox.checked) {
    otherText.style.visibility = 'visible';
    otherText.value = '';
  } else {
    otherText.style.visibility = 'hidden';
  }
};


