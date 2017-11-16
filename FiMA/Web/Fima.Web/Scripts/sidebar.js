$(function () {

    checkWidth();
    checkBurger();

    $(window).resize(function () {
        checkWidth();
        checkBurger();
    });

    $('.burger').click(function (ev) {
        ev.preventDefault();
        $(ev.target.closest('.burger')).toggleClass("burger-selected");
        checkBurger();
    });

    $('.menu-item').click(function (ev) {
        $('.toggle').removeClass('unfold');
        $('.menu-item').removeClass('selected');
        $(ev.target.closest('.menu-item')).addClass('selected');
    });

    $('.submenu-item').click(function (ev) {
        $('.submenu-item').removeClass('sub-selected');
        $(ev.target.closest('.submenu-item')).addClass('sub-selected');
    });

    $('.toggle').click(function (ev) {
        $('.toggle').removeClass('unfold');
        $(ev.target.closest('.toggle')).addClass('unfold');
    });

    $('.unfold').click(function (ev) {
        $(ev.target.closest('.toggle')).removeClass('unfold');
    });

    function checkBurger() {
        if (!$('.burger').hasClass('burger-selected')) {
            $('.menu-item').hide();
            $('.sidebar').css({ "minWidth": 32 });
            $('.sidebar').width(32);
        } else {
            $('.sidebar').css({ "minWidth": 230 });
            $('.menu-item').fadeIn();
        }
    }

    function checkWidth() {
        if ($(window).width() < 480) {
            $('.burger').removeClass('burger-selected');
        } else {
            $('.burger').addClass('burger-selected');
        }
    }
});