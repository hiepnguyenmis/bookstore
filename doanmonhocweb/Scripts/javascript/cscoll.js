jQuery(document).ready(function () {
   // $('.home').hide();
    var pos = $(".menu").offset().top;
	$(window).scroll(function() {
		var posScroll= $(window).scrollTop();
		if(posScroll>=pos){
            $(".menu").addClass("fix");
            //$('.home').show();
		}else{
            $(".menu").removeClass("fix");
            //$('.home').hide();
		}
	})
})