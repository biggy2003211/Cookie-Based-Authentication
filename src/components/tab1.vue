<template>
  <div class="well">
    <img
      src="https://img.eclife.com.tw/photo2011/banner_2020/1/1090130-YU-BLB.jpg"
      alt="3M Tekk (N95) 防粉塵口罩- 閥型舒適款"
      draggable="false"
      class="img-response BLB"
    />
    <div v-for="(lst , index) in WisemanList" :key="index" class="pro-lst">
      <div class="img">
      <img :src="lst.Img" alt="" class="img-response"/></div>
      <div class="txt">
      <h2>{{lst.Title}}</h2></div>
    </div>
  </div>
</template>

<script>
export default {
  name: "tab1",
  props: {
    msg: String
  },
  data() {
    return {
      WisemanList: [
        {
          Title:
            "擬真7.1多聲道遊戲時更聲歷其境—微星 IMMERSE GH50電競耳機【夯貨體驗團】",
          Time: "2020-01-16",
          Cont:
            "【金賺會員獨享 - 良興夯貨體驗團】\r\n體驗會員：良興金賺會員游先生\r\n體驗時間 ：2019.12\r\n這個微星電競耳機，有著40mm大尺吋驅動單體、可拆卸式麥克風，具備RGB LED燈光效果，並且可以折疊攜帶，所以同樣也要來開箱一下，讓有興趣的大大參考。",
          WatchNum: 84,
          Url: "cont855.htm",
          Img:
            "//img.eclife.com.tw/photo2011/wiseman/Article_2020/1/1090102-YJ-462x315.jpg"
        },
        {
          Title: "【良興小教室】筆電挑選指南-WINDOWS篇(中)",
          Time: "2020-01-06",
          Cont:
            "還記得達人上一篇筆電挑選指南嗎？\r\n達人又來上課啦！照過來、照過來，筆記準備好了嗎？\r\n上次講完CPU、RAM、GPU，今天要來繼續聊聊其他硬體設備～\r\n那我們開始囉～孩子，讓專業的來\r\n",
          WatchNum: 537,
          Url: "cont850.htm",
          Img:
            "//img.eclife.com.tw/photo2011/wiseman/Article_2020/1/20200107002.jpg"
        }
      ]
    };
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
