
/* jQuery表单图片上传插件 */

$(function () {

    var imgUploader = function (ele, opt) {
        this.$element = ele,
        this.defaults = {
            labelText: '上传海报：',

        },
        this.options = $.extend({}, this.defaults, opt);
    }

    imgUploader.prototype = {
        getOptions: function (name) {
            if (name != null)
                return this.options[name];
            else
                return this.options;
        }
    }

    $.fn.initImgUploader = function () {

        // 上传图片input
        var file_input = document.createElement('input');
        $(file_input).attr('id', 'inputImgUploader');
        $(file_input).attr('type', 'file');
        $(file_input).addClass('inputImgUploader');

        // 上传控件form
        var wrap_form = document.createElement('form');
        wrap_form.id = 'formImgUploader';
        wrap_form.enctype = 'multipart/form-data';
        $(wrap_form).prepend(file_input);

        // 上传控件label
        var input_label = document.createElement('label');
        $(input_label).addClass('control-label');
        $(input_label).addClass('col-md-2');
        $(input_label).text('上传海报：');

        // 上传图片input容器
        var input_div = document.createElement('div');
        input_div.className = 'col-md-10';
        $(input_div).prepend(wrap_form);

        // 表单输入框组容器
        var form_group_div = document.createElement('div');
        form_group_div.className = 'form-group';
        $(form_group_div).prepend(input_div);
        $(form_group_div).prepend(input_label);

        this.append(form_group_div);
    }

})