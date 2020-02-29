<template>
  <v-app id="app">
    <link href="https://fonts.googleapis.com/css?family=Material+Icons" rel="stylesheet" />

    <v-content>
      <Navbar></Navbar>
      <Users></Users>
    </v-content>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import Auth from "./components/Auth.vue";
import Inscription from "./components/Inscription.vue";
import Navbar from "./components/Navbar.vue";
import Mood from "./components/Mood.vue";
import Quotes from "./components/Quotes.vue";
import Users from "./components/Users.vue";

export default Vue.extend({
  name: "App",

  components: {
    Auth,
    Navbar,
    Mood,
    Quotes,
    Users,
    Inscription
  }
});
</script>

