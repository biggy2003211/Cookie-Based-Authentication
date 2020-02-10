<template>
  <div class="Login">
    <h1>會員登入</h1>
    <form>
      <div class="form-group">
        <input
          id="LoginID"
          class="inp"
          placeholder="請輸入Email / 手機"
          type="text"
          name="LoginID"
          value
        />
        <div id="LoginIDErrMsg" class="tips"></div>
      </div>
      <div class="form-group">
        <input
          id="LoginPwd"
          class="inp"
          placeholder="請輸入密碼"
          type="password"
          name="LoginPwd"
          value
        />
        <div id="LoginPwdErrMsg" class="tips">警告訊息</div>
      </div>
      <div class="form-group">
        <button
          type="button"
          class="btn btnLogin"
        >登入</button>
      </div>
      <div class="form-group or">
        <button
          type="button"
          class="btn btnLine"
        >使用 LINE 登入</button>
      </div>
    </form>
  </div>
</template>

<script>
export default {
  name: "Login",
  props: {
    msg: String
  }
};
</script>

