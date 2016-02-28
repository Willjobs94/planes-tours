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
});