<template>
  <div>
    <Header />
   
    <!-- <ShopIntroduce /> -->
    <Tabs />
    <Login msg="會員登入" />
  </div>
</template>





<script>
import "./css/Header.css";
import "./css/Login.css";
import Header from "./components/Header";
// import ShopIntroduce from "./components/ShopIntroduce";
import Tabs from "./components/Tabs";
import Login from "./components/Login";

//export var name = "李四";

export default {
  name: "login",
  data() {
    return {
      msg: "hello"
    };
  },
  components: {
    Login,
    Header,
    // ShopIntroduce,
    Tabs
  },
  created: function() {
    document.head.innerHTML +=
      "<style>:root {--color-H: 105;  --color-S: 100;  --color-L: 48;  --darken: 0.15;  --primary: hsl(var(--color-H), calc(var(--color-S) * 1%), calc(var(--color-L) * 1%));  --primary-darken: hsl(var(--color-H), calc(var(--color-S) * 1%), calc(var(--color-L) * (1 - var(--darken)) *  1%));  --primary-lighten: hsl(var(--color-H), calc(var(--color-S) * 1%), calc(var(--color-L) * (1 + var(--darken)) *  1%));}</style>";
  }
};
</script>


