;(function($){
    "use strict";
//    
//    $(window).load(function() {
//      $('.flexslider').flexslider({
//          animation: "slide",
//          directionNav:false
//      });
//    });
    var topSlider = function() {
        if ( $().flexslider ) {
            $('.slider-top-area .flexslider').flexslider({
                animation           : "slide",
                controlNav          : true,
                directionNav        : false,
                pauseOnHover        : false, 
                pauseOnAction       : true,
                slideshow           : true,
                animationSpeed      : 500,
                slideshowSpeed      : 5000,
                prevText            :  '<i class="fa fa-angle-left"></i>',
                nextText            :  '<i class="fa fa-angle-right"></i>',
                controlsContainer   : '.flex-container',
                start: function(slider) {
                    slider.removeClass('loading');
                }
            });
        }
    };
    topSlider();
    //======Isotope-recennt-projects-area=====//
    function menuItems(){
        if ( $('#menu-items').length ){
            $('#menu-items').imagesLoaded( function() {
                // Add isotope click function
                $("#menu-filter li").on('click',function(){
                    $("#menu-filter li").removeClass("active");
                    $(this).addClass("active");

                    var selector = $(this).attr("data-filter");
                    $("#menu-items").isotope({
                        filter: selector
                    })
                })
				
            })
        }
    }
    menuItems();
    
    $('.testimonial-slider').owlCarousel({
        loop:true,
        margin:30,
        items:1,
        nav:true,
        navText: ['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        navContainer: '.testimonial-slider',
        autoplay:true,
        
    });
    /*---
    TimePicker
    ---*/
    function timepicker1(){
        if ( $('#timepicker1').length ){
            $('#timepicker1').timepicker();
        }
    }
    timepicker1();
    /*---
    DatePicker
    ---*/
    function datepicker(){
        if ( $('.datepicker').length ){
            $('.datepicker').datepicker();
        }
    }
    datepicker();
    /*----------------------------------------------------*/
    /*  Google Map
    /*----------------------------------------------------*/        
    function mapBox () {
        if ( $( '#mapBox' ).length ){
            var $lat = $('#mapBox').data('lat');
            var $lon = $('#mapBox').data('lon');
            var $zoom = $('#mapBox').data('zoom');
            
            var map = new GMaps({
                el: '#mapBox',
                lat: $lat,
                lng: $lon,
                scrollwheel: false,
                scaleControl: true,
                streetViewControl: true,
                panControl: true,
                disableDoubleClickZoom: true,
                mapTypeControl: true,
                zoom: $zoom
            }) 
        }
    }
    mapBox ();
    /*----------------------------------------------------*/
    /*  Navigation Scroll
    /*----------------------------------------------------*/
    $(window).scroll(function() {    
        var scroll = $(window).scrollTop();

        if (scroll >= 400) {
            $(".menu-below-logo").addClass("scrolled");
        } else {
            $(".menu-below-logo").removeClass("scrolled");
        }
    });
    
    // preloader js
     $(window).load(function() { // makes sure the whole site is loaded
		$('.sampleContainer').fadeOut(); // will first fade out the loading animation
		$('.loader').delay(150).fadeOut('slow'); // will fade out the white DIV that covers the website.
		$('body').delay(150).css({'overflow':'visible'})
    })
})(jQuery)

