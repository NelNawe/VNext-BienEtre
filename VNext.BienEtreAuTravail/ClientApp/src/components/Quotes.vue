<template>
  <v-container>
    <v-content>
      <p
        class="font-weight-black text-center text"
        color="#B2D3A3"
      >Selectionnez la citation qui vous parle le plus</p>
    </v-content>
    <v-content>
      <v-layout justify-center>
        <v-card elevation="0">
          <v-card-text>
            <v-form>
              <v-card elevation="12" color="#B2D3A3">
                <v-input id="citation1" color="#4d8c05" type="text">
                  <blockquote>" Ce n'est pas par des paroles que s'engagent les décisions, mais seulement par le travail. "</blockquote>
                </v-input>
              </v-card>
              <br />
              <v-card elevation="12" color="#B2D3A3">
                <v-input id="citation2" color="#4d8c05" type="text">
                  <p>"Que ton ambition soit de voir, non pas ce que tu pourras tirer du travail, mais ce que tu pourras y mettre de toi."</p>
                </v-input>
              </v-card>
              <br />
              <v-card elevation="12" color="#B2D3A3">
                <v-input id="citation3" color="#4d8c05">
                  <p>" Lorsque deux ou plusieurs personnes joignent leurs efforts dans un esprit d'harmonie et travaillent à la réalisation d'un objectif précis ou d'un projet significatif, elles se placent, par cette alliance, dans une position d'où elles peuvent puiser à la source même de l'intelligence humaine. "</p>
                </v-input>
              </v-card>
            </v-form>
          </v-card-text>
        </v-card>
      </v-layout>
    </v-content>
  </v-container>
</template>
<style>
.text {
  color: #4d8c05;
}
</style>