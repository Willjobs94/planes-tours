(function($) {
   "use strict"; // Start of use strict
   
   // Pre-loader Setting
   $(window).load(function() {
      $("#pre-loader").fadeOut("slow");
   });

   $(window).ready(function() {
      // Intro Vegas Setting
      $("#intro").vegas({
         slides: [
            { src: "/Content/img/img-5.jpg" },
            { src: "/Content/img/img-4.jpg" },
            { src: "/Content/img/img-3.jpg" }
         ]
      });
      
      // Owl-Slider Offers
      var owl = $("#owl-offers");
         
      owl.owlCarousel({
         items : 3,
         itemsDesktop : [1000,3],
         itemsDesktopSmall : [900,2],
         itemsTablet: [600,1],
         itemsMobile : false,
         autoPlay : 3000,
         stopOnHover : true,
         autoHeight : true
      });
      
      $(".prev-1").click(function(){
         owl.trigger('owl.prev');
      });
      $(".next-1").click(function(){
         owl.trigger('owl.next');
      });
         
      // Owl-Slider Best Hotel
      var owlBestHotel = $("#owl-best-hotel");
      
      owlBestHotel.owlCarousel({
         items : 4,
         itemsDesktop : [1000,3],
         itemsDesktopSmall : [900,2],
         itemsTablet: [600,1],
         itemsMobile : false,
         autoPlay : 3000,
         stopOnHover : true,
         autoHeight : true
      });
      
      $(".prev-2").click(function(){
         owlBestHotel.trigger('owl.prev');
      });
      $(".next-2").click(function(){
         owlBestHotel.trigger('owl.next');
      });
      
      // Owl-Slider Hotel Detail
      var owlHotelDetail = $("#owl-hotel-detail");
      
      owlHotelDetail.owlCarousel({
         singleItem: true,
         autoPlay : 3000,
         stopOnHover : true,
         autoHeight : true
      });
      
      $(".prev-3").click(function(){
         owlHotelDetail.trigger('owl.prev');
      });
      $(".next-3").click(function(){
         owlHotelDetail.trigger('owl.next');
      });
      
      // Form Message Validate
      $("#btn-validate").on("click", function() {
         $("#form-validate").validate({
            rules: {
               name: { required: true },
               email: { required: true, email: true },
               message: { required: true }
            },
            messages: {
               name: "Escriba su nombre por favor",
               email: { required: "Escriba su correo por favor", email: "El formato de correo es incorrecto" },
               message: "Escriba su mensaje"
            }
         });
      });
   });
})(jQuery);