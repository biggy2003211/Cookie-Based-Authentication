<template>
  <div class="Header">
    <div class="navBar burger">
      <img src="../img/burger.svg" v-on:click="ShowNav"/>
    </div>
    <div class="navBar logo">HOYA</div>
    <div class="navBar cart">
      <svg width="0px" height="0px" viewBox="0 0 20 20" class="icon-cart">
        <path
          fill-rule="evenodd"
          d="M6.282 12.49c.071.164.04.21.234.411.154.158.576.126.576.126l8.775.023c.678 0 1.29-.422 1.452-1.327l.89-3.794.077-.59c0-.72-.51-1.243-1.14-1.243H6.5l-.435-2.062c-.006-.025-.214-.605-.729-.605H2.471c-.288 0-.757.12-.757.752 0 .574.507.784.795.784l2.118.004 1.519 6.996.136.524zm9.762-1.473s-.053.328-.185.401c-.078.075-.211.08-.211.08l-7.972-.009-.805-3.845 9.661-.025s.185.013.226.126c.03.105-.003.278-.003.278l-.051.332-.66 2.662zm-5.686 4.674c0 .802-.646 1.452-1.443 1.452s-1.444-.65-1.444-1.452c0-.802.647-1.452 1.444-1.452.797 0 1.443.65 1.443 1.452zm5.867 0c0 .802-.646 1.452-1.443 1.452-.798 0-1.444-.65-1.444-1.452 0-.802.646-1.452 1.444-1.452.797 0 1.443.65 1.443 1.452z"
        />
      </svg>
      <span>9</span>
    </div>

    <div class="ShopIntroduce">
      <div class="introduce left">
        <img src="https://img.eclife.com.tw/SmartSell/Store/411.jpg" alt class="img" />
      </div>
      <div class="introduce right">
        <h1 class="pName">{{PerName}} 私藏推薦</h1>
        <p class="txt">{{PerMemo}}</p>
        <p class="txt intelligence">
          粉絲
          <b>8</b> 商品
          <b>25</b>
        </p>
      </div>
      <div class="chat">聊聊 +</div>
    </div>
    <Nav :is="currentNav" keep-alive  v-bind:class="{ ShowNav: isNav }"></Nav>
  </div>
</template>

<script>
import Nav from "./Nav";
export default {
  name: "Header",
  props: {
    msg: String
  },
  data() {
    return {       
      currentNav: "Nav",
      isNav: false,
      PerName: "孫小珍",
      PerMemo: "從吃的到用的，通通報齁哩災從吃的到用的，通通報齁哩災",
      
    };
  },
  components: {
    Nav
  },
  methods: {
    ShowNav: function() {
      this.isNav = true;
    },
    closeNav: function(){
      this.isNav = false;
    }

  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
