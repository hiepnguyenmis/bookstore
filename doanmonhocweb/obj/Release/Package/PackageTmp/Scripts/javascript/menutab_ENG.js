$(document).ready(function () {
    function activeTabENG(obj) {
        $('ul.chooseENG li.column1').removeClass('active');
        $(obj).addClass('active');
        var id = $(obj).find('a').attr('href');
        $('.listbookENG').hide();
        $(id).show();
    }
    $('ul.chooseENG li.column1').click(function () {
        activeTabENG(this);
        return false;
    });
    activeTabENG($('ul.chooseENG li.column1:first-child'));
});