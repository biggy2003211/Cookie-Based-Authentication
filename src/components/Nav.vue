<template>
  <div class="NavCover">
      <div class="Nav">
        <a :href="lst.url" v-for="(lst, index) in Nav" :key="index" class="lst-a">{{lst.name}}</a>
      </div>
      <div class="BgCoverShow" v-on:click="colseNav"></div>
  </div>
</template>

<script>
export default {
  name: "Nav",
  props: {
    msg: String
  },
  data() {
    return {
      Nav: [
        { name: "會員登入", url: "" },
        { name: "商品分類", url: "" },
        { name: "最新活動", url: "" },
        { name: "訂單查詢", url: "" },
        { name: "追蹤收藏", url: "" },
        { name: "服務員聊聊", url: "" },
        { name: "登出 ", url: "" }
      ]
    };
  },
  methods: {
    colseNav() {
    },
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
