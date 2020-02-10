<template>
  <div class="well">
      <h3 v-for="(lst, index) in PerTagLst" :key="index">
        {{lst.TagName}}
    </h3>
  </div>
</template>

<script>
export default {
  name: "tab3",
  props: {
    msg: String
  },
  data() {
    return {
      PerTagLst: [{"TagName":"#3C "},{"TagName":"#生活家電"},{"TagName":"#健康美妝"}]
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
