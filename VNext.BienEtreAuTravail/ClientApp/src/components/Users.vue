<template>
    <div class="App">
        <h1 class="subheading grey--text">Team members</h1>
        <v-container class="my-5">
            <v-content>
                <v-layout row wrap>
                    <v-flex xs12 sm6 md4 lg3 v-for="post in posts">
                        <v-card flat class="text-xs-center ma-3" elevation="5">
                            <v-card-actions>
                                <v-responsive class="pt-4">
                                    <v-avatar size="100">
                                        <img src="@/assets/avatar.png" />
                                    </v-avatar>
                                </v-responsive>
                                <v-spacer></v-spacer>
                                <v-btn text color="grey" style="min-width:20px">
                                    <v-icon medium left color="#1DB954">cloud_upload</v-icon>
                                </v-btn>
                            </v-card-actions>
                            <v-card-text>

                              
                                <div class="subheading">{{ post.pseudo }}</div>
                            </v-card-text>

                            <v-card-actions>
                                <v-btn text color="grey">
                                    <v-icon small left color="#1DB954">message</v-icon>
                                    <span>Contacter</span>
                                </v-btn>
                                <v-spacer></v-spacer>

                                <v-btn text color="grey" style="margin-left:0px ; padding:0 0px" >
                                    <v-icon medium left color="#1DB954">edit</v-icon>
                                </v-btn>
                                <v-btn text color="grey" style="margin-left:0px ;min-width:0px">
                                    <v-icon medium left color="#1DB954" >delete_forever</v-icon>
                                </v-btn>

                            </v-card-actions>
                        </v-card>
                    </v-flex>
                </v-layout>
            </v-content>
        </v-container>
    </div>
</template>

<script lang="ts">
    import Vue from 'vue'
    import axios from 'axios';
    export default Vue.extend({
        name: 'App',
        data() {
            return {
                posts: [],
                errors: []
            }
        },

        created() {
            axios.get(`https://localhost:44380/api/User`, {
                headers: {
                    'Access-Control-Allow-Origin': '*',
                }
            })
                .then(response => {

                    this.posts = response.data
                })
                .catch(e => {
                    this.errors.push()
                })


        }
    })
</script>