<template>
  <div class="well pro">
    <div class="pro-lst" v-for="(lst, index) in PerProdLst" :key="index">
      <div class="img">
        <img :src="lst.ProdImg" alt class="img-response" />
        <template v-if="lst.VideoUrl != null">
          <a :href="lst.VideoUrl" class="video">達人影片</a>
        </template>
      </div>
      <div class="txt">
        <h2 class="name">{{lst.ProdName}}</h2>
        <strong class="memo">{{lst.Memo}}</strong>
        <p>
          <del>{{lst.SalePrice}}</del>
          <b class="sPrice">{{lst.SpicalPrice}}</b>
        </p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "tab2",
  data() {
    return {
      PerProdLst: [
        {
          idx: 0,
          Status: 0,
          Sticky: 0,
          Online: 0,
          ProdNo: "J7100119",
          ProdUrl: "/life/moreinfo_156924.htm",
          ProdImg:
            "https://www.eclife.com.tw/photo2011/prod_2019/9/J7100119-A.jpg",
          ProdName: "荷蘭公主1.6公升健康氣炸鍋(白)-182035W",
          Memo: "推薦 / CP值超高的氣炸鍋\n【煎、炸、烘、烤 健康低油料理】",
          SalePrice: 3800,
          SpicalPrice: 2990,
          SavePrice: 0,
          memSavePrice: 0,
          Yellow_Area_ID: 0,
          mprice: 2990,
          sprice: 3800,
          VideoUrl: "https://www.youtube.com/watch?v=U5jqC72WYng",
          ArticleUrl: null
        },
        {
          idx: 0,
          Status: 0,
          Sticky: 0,
          Online: 0,
          ProdNo: "J7100120",
          ProdUrl: "/life/moreinfo_160162.htm",
          ProdImg:
            "https://www.eclife.com.tw/photo2011/prod_2019/12/J7100120-A.jpg",
          ProdName: "[未來實驗室] AIRFRYER  渦輪氣炸鍋",
          Memo: "快速導熱鎖住食材原味\n獨家熱循環輕鬆做到烤炸煎煮",
          SalePrice: 1980,
          SpicalPrice: 1980,
          SavePrice: 0,
          memSavePrice: 0,
          Yellow_Area_ID: 0,
          mprice: 1980,
          sprice: 1980,
          VideoUrl: "https://www.youtube.com/watch?v=UQFOIF6u2fc",
          ArticleUrl: null
        },
        {
          idx: 0,
          Status: 0,
          Sticky: 0,
          Online: 0,
          ProdNo: "J7100128",
          ProdUrl: "/life/moreinfo_161356.htm",
          ProdImg:
            "https://www.eclife.com.tw/photo2011/prod_2020/1/J7100128-A.jpg",
          ProdName: "THOMSON 2.5L氣炸鍋TM-SAT17A(氣質白)",
          Memo: "大容量：外鍋 3L/內鍋 2.5L",
          SalePrice: 3990,
          SpicalPrice: 3990,
          SavePrice: 0,
          memSavePrice: 0,
          Yellow_Area_ID: 0,
          mprice: 3990,
          sprice: 3990,
          VideoUrl: null,
          ArticleUrl: null
        },
        {
          idx: 0,
          Status: 0,
          Sticky: 0,
          Online: 0,
          ProdNo: "J8001055",
          ProdUrl: "/none/moreinfo_161145.htm",
          ProdImg: "https://www.eclife.com.tw/photo2011/prod_2020/1/129398.jpg",
          ProdName: "ASO阿瘦羅媽咪七星報喜豪華年菜組",
          Memo: "過年羅媽咪年菜讓你的媽媽也一起舒服爽過年",
          SalePrice: 3680,
          SpicalPrice: 3680,
          SavePrice: 0,
          memSavePrice: 0,
          Yellow_Area_ID: 0,
          mprice: 3680,
          sprice: 3680,
          VideoUrl: null,
          ArticleUrl: null
        },
        {
          idx: 0,
          Status: 0,
          Sticky: 0,
          Online: 0,
          ProdNo: "V7240117",
          ProdUrl: "/life/moreinfo_160446.htm",
          ProdImg:
            "https://www.eclife.com.tw/photo2011/prod_2019/12/V7240117-A.jpg",
          ProdName: "嘉儀雷姬掃拖機器人  LEGEE688",
          Memo: "◎吸擦噴拖四合一機器人\n◎仿人手擦拭每分鐘往復600下\n",
          SalePrice: 12800,
          SpicalPrice: 12800,
          SavePrice: 0,
          memSavePrice: 0,
          Yellow_Area_ID: 0,
          mprice: 12800,
          sprice: 12800,
          VideoUrl: "https://www.youtube.com/watch?v=Q7cnga2ztzM&feature=",
          ArticleUrl: null
        }
      ]
    };
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
