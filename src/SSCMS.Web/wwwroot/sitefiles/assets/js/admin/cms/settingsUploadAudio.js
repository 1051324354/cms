﻿var $url = '/cms/settings/settingsUploadAudio';

var data = utils.init({
  siteId: utils.getQueryInt("siteId"),
  pageType: null,
  form: null,
  csrfToken: null,
  isSafeMode: false
});

var methods = {
  apiGet: function () {
    var $this = this;

    utils.loading(this, true);
    $api.get($url, {
      params: {
        siteId: this.siteId
      }
    }).then(function (response) {
      var res = response.data;

      $this.csrfToken = res.csrfToken;
      $this.isSafeMode = res.isSafeMode;

      $this.form = {
        siteId: $this.siteId,
        audioUploadDirectoryName: res.audioUploadDirectoryName,
        audioUploadDateFormatString: res.audioUploadDateFormatString,
        isAudioUploadChangeFileName: res.isAudioUploadChangeFileName,
        audioUploadExtensions: res.audioUploadExtensions,
        audioUploadTypeMaxSize: res.audioUploadTypeMaxSize,
      };
    }).catch(function (error) {
      utils.error(error);
    }).then(function () {
      utils.loading($this, false);
    });
  },

  apiSubmit: function () {
    var $this = this;

    utils.loading(this, true);
    $api.csrfPost(this.csrfToken, $url, this.form).then(function (response) {
      var res = response.data;

      utils.success('音频上传设置保存成功！');
    }).catch(function (error) {
      utils.error(error);
    }).then(function () {
      utils.loading($this, false);
    });
  },

  btnSubmitClick: function () {
    var $this = this;
    this.$refs.form.validate(function(valid) {
      if (valid) {
        $this.apiSubmit();
      }
    });
  }
};

var $vue = new Vue({
  el: '#main',
  data: data,
  methods: methods,
  created: function () {
    this.apiGet();
  }
});
