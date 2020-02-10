<template>
  <div>
    <ul class="Tabs">
      <li
        class="tabLst"
        v-for="(tab,index) in tabs"
        :key="index"
        @click="toggleTab(index,tab.type)"
        :class="{active:active===index}"
      >
        <a>{{tab.view}}</a>
      </li>
    </ul>
    <tab1 :is="currentTab" keep-alive></tab1>
  </div>
</template>

<script>
import tab1 from "./tab1";
import tab2 from "./tab2";
import tab3 from "./tab3";
export default {
  name: "Tabs",
  props: {
    msg: String
  },
  data() {
    return {
      active: 0,
      currentTab: "tab1",
      tabs: [
        {
          type: "tab1",
          view: "爆文好貨"
        },
        {
          type: "tab2",
          view: "精選推薦"
        },
        {
          type: "tab3",
          view: "活動特輯"
        }
      ]
    };
  },
  components: {
    tab1,tab2,tab3
  },
  methods: {
    toggleTab: function(i, tab) {
      this.currentTab = tab; // tab 為當前的 tab
      this.active = i; //當前的tab 加上class active
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
