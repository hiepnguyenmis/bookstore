$(document).ready(function () {
    $(".slideshow > div:gt(0)").hide();
    var slidesl = $('.slideitem').length
    var d = "<li class=\"dot active-dot\">&bull;</li>";
    for (var i = 1; i < slidesl; i++) {
        d = d + "<li class=\"dot\">&bull;</li>";
    }
    var dots = "<ul class=\"slider-dots\">" + d + "</ul\>";

    $(".slideshow").append(dots);
    var interval = setInterval(slide, 7000);

    function intslide(func) {
        if (func == 'start') {
            interval = setInterval(slide, 7000);
        } else {
            clearInterval(interval);
        }
    }

    function slide() {
        sact('next', 0, 1200);
    }

    function sact(a, ix, it) {
        var currentSlide = $('.current');
        var nextSlide = currentSlide.next('.slideitem');
        var prevSlide = currentSlide.prev('.slideitem');
        var reqSlide = $('.slideitem').eq(ix);

        var currentDot = $('.active-dot');
        var nextDot = currentDot.next();
        var prevDot = currentDot.prev();
        var reqDot = $('.dot').eq(ix);

        if (nextSlide.length == 0) {
            nextDot = $('.dot').first();
            nextSlide = $('.slideitem').first();
        }

        if (prevSlide.length == 0) {
            prevDot = $('.dot').last();
            prevSlide = $('.slideitem').last();
        }

        if (a == 'next') {
            var Slide = nextSlide;
            var Dot = nextDot;
        }
        else if (a == 'prev') {
            var Slide = prevSlide;
            var Dot = prevDot;
        }
        else {
            var Slide = reqSlide;
            var Dot = reqDot;
        }

        currentSlide.fadeOut(it).removeClass('current');
        Slide.fadeIn(it).addClass('current');

        currentDot.removeClass('active-dot');
        Dot.addClass('active-dot');
    }

    $('.dot').on('click', function () {
        intslide('stop');
        var index = $(this).index();
        sact('dot', index, 400);
        intslide('start');
    });
});
