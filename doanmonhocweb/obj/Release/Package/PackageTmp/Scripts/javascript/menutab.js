$(document).ready(function() {
    function activeTab(obj) {
        $('ul.choose li.col1').removeClass('acti');
        $(obj).addClass('acti');
        var id = $(obj).find('a').attr('href');
        $('.list-book').hide();
        $(id).show();
    }
    $('ul.choose li.col1').click(function () {
        activeTab(this);
        return false;
    });
    activeTab($('ul.choose li.col1:first-child'));
});