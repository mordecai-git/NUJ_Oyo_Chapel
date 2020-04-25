(function ($) {
  "use strict";

  $(document).ready(function() {
    $('select').niceSelect();
  });
  // menu fixed js code
  $(window).scroll(function () {
    var window_top = $(window).scrollTop() + 1;
    if (window_top > 50) {
      $('.main_menu').addClass('menu_fixed animated fadeInDown');
    } else {
      $('.main_menu').removeClass('menu_fixed animated fadeInDown');
    }
  });

$(document).ready(function() {
  $('select').niceSelect();
});

//------- Mailchimp js --------//  
function mailChimp() {
  $('#mc_embed_signup').find('form').ajaxChimp();
}
mailChimp();

// ------- CURRENT ACTIVITY SECTION ------//
$('.owl-carousel').owlCarousel({
  stagePadding: 200,
  loop:true,
  margin:10,
  nav:false,
  items:1,
  lazyLoad: true,
  nav:true,
responsive:{
      0:{
          items:1,
          stagePadding: 60
      },
      600:{
          items:1,
          stagePadding: 100
      },
      1000:{
          items:1,
          stagePadding: 200
      },
      1200:{
          items:1,
          stagePadding: 250
      },
      1400:{
          items:1,
          stagePadding: 300
      },
      1600:{
          items:1,
          stagePadding: 350
      },
      1800:{
          items:1,
          stagePadding: 400
      }
  }
});

}(jQuery));

