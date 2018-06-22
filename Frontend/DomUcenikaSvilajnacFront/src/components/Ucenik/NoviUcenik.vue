<template>
<v-container>
    <v-layout row>
        <v-flex xs12>
            <h1  > Prijava novog ucenika</h1>
        </v-flex>
    </v-layout>
    <v-layout row>
        <v-flex xs12>
            <form >
                <v-layout row>
                    <v-flex xs12 sm6 offset-sm3>
                        <v-text-field name="Ime"
                            label="Ime"
                            id="ime"
                            requiered>
                            
                        </v-text-field>
                    </v-flex>
                </v-layout>
            </form>
        </v-flex>
    </v-layout>
</v-container>
</template>