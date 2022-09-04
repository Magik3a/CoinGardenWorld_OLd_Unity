// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

//export function showPrompt(message) {
//  return prompt(message, 'Type anything here');
//}
 function getBlazorCulture() {
    return window.localStorage['BlazorCulture'];
};
 function setBlazorCulture(value) {
    window.localStorage['BlazorCulture'] = value;
};

function loadCultureSelect2() {
    var $select = $(".culture-selector");
    if ($select.exists()) {
        $select.each(function () {
            var $self = $(this),
                _theme = ($self.data('select2-theme')) ? $self.data('select2-theme') : 'bordered',
                _place = ($self.data('select2-placehold')) ? $self.data('select2-placehold') : 'Select an option';
            $self.select2({ placeholder: _place, theme: "default select-" + _theme });
        });
    }

    $select.on('select2:select', function (e) {
        var data = e.params.data;
        console.log(data);
        setBlazorCulture(data.id);
        $("#culture-options").val(data.id).change();
    });

}