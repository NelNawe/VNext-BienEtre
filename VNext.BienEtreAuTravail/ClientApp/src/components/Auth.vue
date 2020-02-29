<template>

  <v-container>
<v-content>
    <v-layout justify-center>
      <v-card color="#B2D3A3" flat shaped elevation="12" height=auto>
        <v-toolbar color="#B2D3A3" flat>
          <v-spacer></v-spacer>
          <v-toolbar-title>Authentification</v-toolbar-title>
          <v-spacer></v-spacer>
        </v-toolbar>

        <v-divider></v-divider>

        <v-card-text>
          
          <v-form>
            <v-text-field
              label="Departement"
              color="#4d8c05"
              height="40"
              name="department"
              prepend-icon="group"
              type="text"
            ></v-text-field>

            <v-text-field
              label="Pseudo"
              color="#4d8c05"
              height="40"
              name="login"
              prepend-icon="person"
              type="text"
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
 </v-content>
  </v-container>
 
 
</template>
<style>
.v-card:not(.v-sheet--tile):not(.v-card--shaped) {
  border-radius: 40px;
}
</style>