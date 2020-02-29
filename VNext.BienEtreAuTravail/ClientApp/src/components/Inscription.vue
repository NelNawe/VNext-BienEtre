<template>
  <v-container style="padding:40px">
    <v-layout justify-center>
      <v-card color="#B2D3A3" flat shaped elevation="12" height=auto>
        <v-toolbar color="#B2D3A3" flat>
          <v-spacer></v-spacer>
          <v-toolbar-title>INSCRITPTION</v-toolbar-title>

          <v-spacer></v-spacer>
        </v-toolbar>

        <v-divider></v-divider>

        <v-card-text>
          <v-form>
            <v-text-field label="Pseudo" height="40" name="login" prepend-icon="person" type="text"></v-text-field>

            <v-text-field
              id="password"
              height="40"
              label="Mot de passe"
              name="password"
              prepend-icon="lock"
              type="password"
            ></v-text-field>
          </v-form>
        </v-card-text>
        <v-card-actions class="justify-center">
          <v-btn small depressed color="#6DB041" dark rounded>
            <span>Valider</span>
            <v-icon small right>done</v-icon>
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-layout>
  </v-container>
</template>
<style>
.v-card:not(.v-sheet--tile):not(.v-card--shaped) {
  border-radius: 40px;
}
</style>