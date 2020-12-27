$(document).ready(function () {
  'use strict';

  //===== Menu Active =====//
  var pgurl = window.location.href.substr(window.location.href.lastIndexOf("/") + 1);
  $("nav ul li a").each(function () {
    if ($(this).attr("href") == pgurl || $(this).attr("href") == '')
    $(this).parent('li').addClass("active").parent().parent().addClass("active").parent().parent().parent().addClass("active");
  });

  $(".responsive-menu ul li a").each(function () {
    if ($(this).attr("href") == pgurl || $(this).attr("href") == '')
    $(this).parent('li').addClass("active").parent().parent().addClass("active").parent().parent().addClass("active");
  });

  //===== Service Hover =====//
  $('.service-caro .service-box-wrap').each(function () {
    $(".service-box-wrap").on('mouseenter', function () {
      $(this).parent().parent().parent().find(".service-box-wrap, .slick-slide").removeClass("hover");
      $(this).parent().parent().addClass("hover");
    });
  });

  $('.service-wrap ul li').each(function () {
    $(".service-box-wrap").on('mouseenter', function () {
      $(this).parent().parent().find(".service-box-wrap").removeClass("hover");
      $(this).addClass("hover");
    });
  });

  $('.seo-result-wrap div.row div').each(function () {
    $(".seo-result-box").on('mouseenter', function () {
      $(this).parent().parent().find(".seo-result-box").removeClass("hover");
      $(this).addClass("hover");
    });
  });

  //===== Scroll To Top =====//
  $('.scroll-top-btn').on('click',function() {
    $('html,body').animate({
      scrollTop: $('body').offset().top
    }, 1000);
  });

  //===== Wow Animation Setting =====//
  if ($(".wow").length > 0) {
    var wow = new WOW({
      boxClass:     'wow',      // default
      animateClass: 'animated', // default
      offset:       0,          // default
      mobile:       true,       // default
      live:         true        // default
    }); 

    wow.init();
  }

  //===== Toggles =====//
  if ($("#toggle2").length > 0) {
    $(function() {
      $('#toggle2 .toggle-content2').hide();
      $('#toggle2 h4:first').next().slideDown(500).parent().addClass("activate");
      $('#toggle2 h4').on("click",function() {
        $(this).next().slideToggle('slow').parent().toggleClass("activate");
      });
    });
  }

  //===== Accordions =====//
  if ($(".toggle").length > 0) {
    $(function() {
      $('#toggle .toggle-content').hide();
      $('#toggle h4:first').next().slideDown(500).parent().addClass("activate");
      $('#toggle h4').on("click",function() {
        if($(this).next().is(':hidden')) {
          $('#toggle h4').next().slideUp(500).parent().removeClass("activate");
          $(this).next().slideDown(500).parent().toggleClass("activate");
        }
      });
    });
  }

  //===== Progress Bar =====//
  if ($(".analys-box").length > 0) {
    $("#analys1").waypoint(function(){
      $("#analys1").circleProgress({
      value: 0.8,
      fill: {color: '#1ec6be'},
      thickness: 3,
      emptyFill: '#f7f7f7',
      size: 190
      }).on('circle-animation-progress', function(event, progress) {
        $(this).find('span').html(Math.round(80 * progress) + '<i>%</i>');
      });
    }, { offset: '80%'})
  }

  if ($(".analys-box").length > 0) {
    $("#analys2").waypoint(function(){
      $("#analys2").circleProgress({
      value: 0.6,
      fill: {color: '#1ec6be'},
      thickness: 3,
      emptyFill: '#f7f7f7',
      size: 190
      }).on('circle-animation-progress', function(event, progress) {
        $(this).find('span').html(Math.round(60 * progress) + '<i>%</i>');
      });
    }, { offset: '80%'})
  }

  if ($(".analys-box").length > 0) {
    $("#analys3").waypoint(function(){
      $("#analys3").circleProgress({
      value: 0.5,
      fill: {color: '#1ec6be'},
      thickness: 3,
      emptyFill: '#f7f7f7',
      size: 190
      }).on('circle-animation-progress', function(event, progress) {
        $(this).find('span').html(Math.round(50 * progress) + '<i>%</i>');
      });
    }, { offset: '80%'})
  }

  if ($(".analys-box").length > 0) {
    $("#analys4").waypoint(function(){
      $("#analys4").circleProgress({
      value: 0.7,
      fill: {color: '#1ec6be'},
      thickness: 3,
      emptyFill: '#f7f7f7',
      size: 190
      }).on('circle-animation-progress', function(event, progress) {
        $(this).find('span').html(Math.round(70 * progress) + '<i>%</i>');
      });
    }, { offset: '80%'})
  }

  if ($(".analys-box").length > 0) {
    $("#analys11").waypoint(function(){
      $("#analys11").circleProgress({
      value: 0.8,
      fill: {color: '#1f5abc'},
      thickness: 3,
      emptyFill: '#f7f7f7',
      size: 190
      }).on('circle-animation-progress', function(event, progress) {
        $(this).find('span').html(Math.round(80 * progress) + '<i>%</i>');
      });
    }, { offset: '80%'})
  }

  if ($(".analys-box").length > 0) {
    $("#analys22").waypoint(function(){
      $("#analys22").circleProgress({
      value: 0.9,
      fill: {color: '#1f5abc'},
      thickness: 3,
      emptyFill: '#f7f7f7',
      size: 130
      }).on('circle-animation-progress', function(event, progress) {
        $(this).find('span').html(Math.round(90 * progress) + '<i>%</i>');
      });
    }, { offset: '80%'})
  }

  if ($(".analys-box").length > 0) {
    $("#analys33").waypoint(function(){
      $("#analys33").circleProgress({
      value: 0.6,
      fill: {color: '#ffe27a'},
      thickness: 3,
      emptyFill: '#f7f7f7',
      size: 190
      }).on('circle-animation-progress', function(event, progress) {
        $(this).find('span').html(Math.round(60 * progress) + '<i>%</i>');
      });
    }, { offset: '80%'})
  }

  if ($(".analys-box").length > 0) {
    $("#analys44").waypoint(function(){
      $("#analys44").circleProgress({
      value: 0.65,
      fill: {color: '#ffe27a'},
      thickness: 3,
      emptyFill: '#f7f7f7',
      size: 130
      }).on('circle-animation-progress', function(event, progress) {
        $(this).find('span').html(Math.round(65 * progress) + '<i>%</i>');
      });
    }, { offset: '80%'})
  }

  //===== Cart Dropdown =====//
  $('.cart-lst > span').on('click', function () {
    $(this).next('div.cart-lst-innr').toggleClass('active');
    return false;
  });

  //===== Header Search =====//
  $('.search-btn').on('click', function () {
    $('.header-search').addClass('active');
    return false;
  });
  $('.search-close-btn').on('click', function () {
    $('.header-search').removeClass('active');
    return false;
  });

  //===== Responsive Header =====//
  $('.responsive-menu-btn').on('click', function () {
    $('body').addClass('slidein');
    return false;
  });
  $('html, body').on('click', function () {
    $('body').removeClass('slidein');
  });
  $('.responsive-menu').on('click', function (event) {
    event.stopPropagation();
  });
  $('.responsive-menu li.menu-item-has-children > a').on('click', function () {
    $(this).parent().siblings('li').children('ul').slideUp();
    $(this).parent().siblings('li').removeClass('active');
    $(this).parent().children('ul').slideToggle();
    $(this).parent().toggleClass('active');
    return false;
  });

  //===== Sticky Sidebar =====//
  if ($('.port-detail-wrap > div.row > div.col-lg-8, .port-detail-wrap > div.row > div.col-lg-4').length > 0) {
    $('.port-detail-wrap > div.row > div.col-lg-8, .port-detail-wrap > div.row > div.col-lg-4').theiaStickySidebar({
      additionalMarginTop: 60,
      additionalMarginBottom: 60
    });
  }

  //===== Clander =====//
  if ($('.myCalendar').length > 0) {
    $('.myCalendar').calendar({
      date: new Date(),
      autoSelect: false, // false by default
      select: function(date) {
        console.log('SELECT', date)
      },
      toggle: function(y, m) {
        console.log('TOGGLE', y, m)
      }
    })
  }

  //===== Range Slider =====//
  if ($('#prod-filter').length > 0) {
    var nonLinearSlider = document.getElementById('prod-filter');
    noUiSlider.create(nonLinearSlider, {
      connect: true,
      behaviour: 'tap',
      start: [15, 35],
      range: {
        'min': [10],
        'max': [40]
      }
    });
    var nodes = [
      document.getElementById('lower-value'),
      document.getElementById('upper-value')
    ];
    nonLinearSlider.noUiSlider.on('update', function (values, handle, unencoded, isTap, positions) {
      nodes[handle].innerHTML = values[handle] + '$';
    });
  }

  //===== Scrollbar =====//
  if ($('.responsive-menu').length > 0) {
    var ps = new PerfectScrollbar('.responsive-menu');
  }

  //===== Select =====//
  if ($('select').length > 0) {
    $('select').selectpicker();
  }

  //===== Header =====//
  if ($.isFunction($.fn.scrollupbar)) {
    $('header').scrollupbar();
  }

  //===== Counter Up =====//
  if ($.isFunction($.fn.counterUp)) {
    $('.counter').counterUp({
      delay: 10,
      time: 2000
    });
  }

  //===== LightBox =====//
  if ($.isFunction($.fn.fancybox)) {
    $('[data-fancybox],[data-fancybox="gallery"]').fancybox({});
  }

  var width = window.innerWidth;
  if(width < 850) {
    // Responsive Carousel
    if ($.isFunction($.fn.slick)) {
      $('.related-inner > .row').slick({
        slidesToShow: 2,
        slidesToScroll: 1,
        dots: true,
        arrows: false,
        centerPadding: '0',
        focusOnSelect: true,
        responsive: [
        {
          breakpoint: 1030,
          settings: {
            slidesToShow: 2,
            slidesToScroll: 1,
            infinite: true,
            arrows: false,
          }
        },
        {
          breakpoint: 980,
          settings: {
            slidesToShow: 2,
            slidesToScroll: 1,
            infinite: true,
            arrows: false,
          }
        },
        {
          breakpoint: 771,
          settings: {
            slidesToShow: 2,
            slidesToScroll: 1,
            infinite: true,
            arrows: false,
          }
        },
        {
          breakpoint: 481,
          settings: {
            slidesToShow: 1,
            slidesToScroll: 1,
            infinite: true,
            centerMode: true,
            arrows: false,
          }
        }
        ]
      });  
    }
  }

  //===== Slick Carousel =====//
  if ($.isFunction($.fn.slick)) {

    //=== Services Carousel ===//
    $('.service-caro').slick({
      slidesToShow: 3,
      slidesToScroll: 1,
      dots: false,
      arrows: true,
      centerPadding: '0',
      focusOnSelect: true,
      responsive: [
      {
        breakpoint: 1030,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 1,
          infinite: true,
          arrows: false,
        }
      },
      {
        breakpoint: 980,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1,
          infinite: true,
          arrows: false,
        }
      },
      {
        breakpoint: 770,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1,
          infinite: true,
          arrows: false,
        }
      },
      {
        breakpoint: 481,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
          centerMode: true,
          arrows: false,
        }
      }
      ]
    });

    //=== Blog Carousel ===//
    $('.blog-caro').slick({
      slidesToShow: 3,
      slidesToScroll: 1,
      dots: false,
      arrows: true,
      centerPadding: '0',
      focusOnSelect: true,
      responsive: [
      {
        breakpoint: 1030,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 1,
          infinite: true,
          arrows: false,
        }
      },
      {
        breakpoint: 980,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1,
          infinite: true,
          arrows: false,
        }
      },
      {
        breakpoint: 770,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1,
          infinite: true,
          arrows: false,
        }
      },
      {
        breakpoint: 481,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
          centerMode: true,
          arrows: false,
        }
      }
      ]
    });

    //=== Testimonials Carousel ===//
    $('.testi-caro').slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      dots: true,
      arrows: true,
      centerPadding: '0',
      focusOnSelect: true,
      responsive: [
      {
        breakpoint: 980,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
        }
      },
      {
        breakpoint: 770,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
        }
      },
      {
        breakpoint: 481,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
          centerMode: true,
          arrows: false,
        }
      }
      ]
    });

    //=== Testimonials Carousel 2 ===//
    $('.testi-caro2').slick({
      slidesToShow: 3,
      slidesToScroll: 1,
      dots: true,
      arrows: false,
      centerPadding: '0',
      focusOnSelect: true,
      centerMode: true,
      responsive: [
      {
        breakpoint: 980,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 1,
          infinite: true,
        }
      },
      {
        breakpoint: 770,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1,
          infinite: true,
        }
      },
      {
        breakpoint: 481,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
          centerMode: true,
        }
      }
      ]
    });

    //=== Mini Post Carousel ===//
    $('.mini-post-caro').slick({
      slidesToShow: 3,
      slidesToScroll: 1,
      dots: false,
      arrows: true,
      centerPadding: '0',
      focusOnSelect: true,
      vertical: true
    });

    //=== Portfolio Detail Image Carousel ===//
    $('.port-detail-img-caro').slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      dots: true,
      arrows: false,
      autoplay: true,
      autoplaySpeed: 4000,
      fade: true,
      centerPadding: '0',
      focusOnSelect: true
    });

    //=== Gallery Carousel ===//
    $('.gallery-caro2').slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      dots: true,
      arrows: true,
      autoplay: true,
      autoplaySpeed: 4000,
      fade: true,
      centerPadding: '0',
      focusOnSelect: true
    });

    //=== Product Carousel ===//
    $('.prod-caro').slick({
      slidesToShow: 4,
      slidesToScroll: 1,
      dots: true,
      arrows: false,
      centerPadding: '0',
      focusOnSelect: true,
      responsive: [
      {
        breakpoint: 980,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1,
          infinite: true,
        }
      },
      {
        breakpoint: 770,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1,
          infinite: true,
        }
      },
      {
        breakpoint: 481,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
          centerMode: true,
        }
      }
      ]
    });

    //=== Gallery Carousel ===//
    $('.gallery-caro').slick({
      slidesToShow: 4,
      slidesToScroll: 1,
      dots: false,
      arrows: true,
      centerPadding: '0',
      focusOnSelect: true,
      responsive: [
      {
        breakpoint: 980,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 1,
          infinite: true,
        }
      },
      {
        breakpoint: 770,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 1,
          infinite: true,
        }
      },
      {
        breakpoint: 481,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
          centerMode: true,
        }
      }
      ]
    });

  }

  //Subscribe Form
  if($('#subscribe-form').length){
    $('#subscribe-newslatters').click(function(){
      
      var o = new Object();
      var form = '#subscribe-form';
      var email = $('#subscribe-form .email').val();
      
      if(email == '')
      {
        $('#subscribe-form .response').html('<div class="failed">Please enter your Email Address.</div>');
        return false;
      }
            
        $.ajax({
            url:"sendnewslatters.php",
            method:"POST",
            data: $(form).serialize(),
            beforeSend:function(){
                $('#subscribe-form .response').html('<div class="text-info"><img src="assets/images/preloader.gif"> Loading...</div>');
            },
            success:function(data){
                $('form').trigger("reset");
                $('#subscribe-form .response').fadeIn().html(data);
                setTimeout(function(){
                    $('#subscribe-form .response').fadeOut("slow");
                }, 5000);
            },
            error:function(){
                $('#subscribe-form .response').fadeIn().html(data);
            }
        });
    });
  }

  //Contact Form Validation
  if($('#email-form').length){
    $('#submit').click(function(){
      
            var o = new Object();
            var form = '#email-form';
      
            var fname = $('#email-form .fname').val();
            var lname = $('#email-form .lname').val();
            var email = $('#email-form .email').val();
            var phone = $('#email-form .phone').val();
      
      if(fname == '' || email == '')
      {
        $('#email-form .response').html('<div class="failed">Please fill the required fields.</div>');
        return false;
      }
            
      $.ajax({
          url:"sendemail.php",
          method:"POST",
          data: $(form).serialize(),
          beforeSend:function(){
              $('#email-form .response').html('<div class="text-info"><img src="assets/images/preloader.gif"> Loading...</div>');
          },
          success:function(data){
              $('form').trigger("reset");
              $('#email-form .response').fadeIn().html(data);
              setTimeout(function(){
                  $('#email-form .response').fadeOut("slow");
              }, 5000);
          },
          error:function(){
              $('#email-form .response').fadeIn().html(data);
          }
      });
  });
  }

}); //===== Document Ready Ends =====//

jQuery(window).on('load',function(){
  'use strict';

  var menu_height = $('header').innerHeight();
  $(window).on('scroll',function () {
    var scroll = $(window).scrollTop();
    if (scroll >= menu_height) {
      $('header.stick').addClass('sticky');
    } else {
      $('.stick').removeClass('sticky');
    }
  });

  
  if ($('header.style2').hasClass('stick')) {
    $('main').css({'padding-top': menu_height});
  }
  if ($('header.style3').hasClass('stick')) {
    $('main').css({'padding-top': menu_height});
  }
  if ($('header.style4').hasClass('stick')) {
    $('main').css({'padding-top': menu_height});
  }

  if ($('nav ul li').hasClass('active')) {
    $(this).parent().parent('li').addClass("active");
  }

  jQuery('#mta-page-loader-container').fadeOut('slow');

  //===== Isotope =====//
  if (jQuery('.fltr-itm').length > 0) {
    if (jQuery().isotope) {
      var jQuerycontainer = jQuery('.masonry'); // cache container
      jQuerycontainer.isotope({
        itemSelector: '.fltr-itm',
        columnWidth: .1,
        layoutMode: 'fitRows'
      });
      jQuery('.fltr-btns a').on('click',function () {
        var selector = jQuery(this).attr('data-filter');
        jQuery('.fltr-btns li').removeClass('active');
        jQuery(this).parent().addClass('active');
        jQuerycontainer.isotope({ filter: selector });
        return false;
      });
      jQuerycontainer.isotope('layout'); // layout/layout
    }

    jQuery(window).resize(function () {
      if (jQuery().isotope) {
        jQuery('.masonry').isotope('layout'); // layout/relayout on window resize
      }
    });
  }
});//===== Window onLoad Ends =====//