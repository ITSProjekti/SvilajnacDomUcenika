    <template>
        <v-container>
            <v-layout row>
                <v-flex xs12 >
                    <transition name="slidetoleft" appear>
                        <h1> Nova soba</h1>
                </transition>
                </v-flex>
                </v-layout>
                <v-form
                    ref="form"
                    v-model="valid"
                    lazy-validation
                    >
                <template>
            <v-container fluid>
            <v-layout row wrap>
            <v-flex offset-sm1 xs12 sm5 class="mt-4 ">
            <v-text-field
            color="navbarcolor"
            v-model="editModel.BrojSobe"
            :rules="[rules.required,rules.BrojSobeRules]"
            onkeydown="javascript: if(event.keyCode == 69) {return false} else
            {
            if(event.keyCode == 107) {return false}
            else {
            if(event.keyCode == 190) {return false}
            else {
            if(event.keyCode == 109) {return false}
            else {
            if(event.keyCode == 187) {return false}
            else {
            if(event.keyCode == 189) {return false}
            else
            {return true} } } } } }"
            label="Broj sobe"
            required
            clearable
            progress
            input type="number"
            ></v-text-field>
            </v-flex>
            <v-flex xs12 sm3 offset-sm1 class="mt-4">
            </v-flex>
            </v-layout>
            </v-container>
            </template>

                <template>
                <v-container fluid>
                <v-layout row wrap>
                <v-flex offset-sm1 xs12 sm5 class="mt-4 ">
                <v-select
                color="navbarcolor"
                v-model="editModel.Sprat"
                :items="rules.spratovi"
                :rules="[rules.required]"
                label="Sprat"
                required
                ></v-select>
                </v-flex>
                <v-flex xs12 sm3 offset-sm1 class="mt-4">
                </v-flex>
                </v-layout>
                </v-container>
                </template>

            <template>
            <v-container fluid>
            <v-layout row wrap>
            <v-flex offset-sm1 xs12 sm5 class="mt-4 ">
            <v-select
            color="navbarcolor"
            v-model="editModel.vrste"
            :items="rules.vrste"
            :rules="[rules.required]"
            label="Vrsta sobe"
            required
            ></v-select>
            </v-flex>
            <v-flex xs12 sm3 offset-sm1 class="mt-4">
            </v-flex>
            </v-layout>
            </v-container>
            </template>

            <template>
            <v-container fluid>
            <v-layout row wrap>
            <v-flex offset-sm1 xs12 sm5 class="mt-4 ">
            <v-select
            color="navbarcolor"
            v-model="editModel.TipSobe"
            :items="rules.tipovi"
            :rules="[rules.required]"
            label="Tip sobe"
            required
            ></v-select>
            </v-flex>
            <v-flex xs12 sm3 offset-sm1 class="mt-4">
            </v-flex>
            </v-layout>
            </v-container>
            </template>

           

            <template>
            <v-container fluid>
            <v-layout row wrap>
            <v-flex offset-sm1 xs12 sm5 class="mt-4 ">
            <v-btn
            color="success"
            @click="submit"
            >
            Validate
            </v-btn>

            <v-btn
            color="error"
            @click="reset"
            >
            Reset Form
            </v-btn>
            </v-flex>
            <v-flex xs12 sm3 offset-sm1 class="mt-4">
            </v-flex>
            </v-layout>
            </v-container>
            </template>
            </v-form>
            </v-container>

    </template>




    <script>
    export default {
    data: () => ({
    rules:{
    valid: true,
    required: (value) => !!value || 'Ovo polje je obavezno.',
    BrojSobeRules: (value) => {
    const pattern = /^\d{3}$/
    return pattern.test(value) || 'Broj sobe mora biti od 100 do 999.'
    },
    spratovi:[
    'I sprat',
    'II sprat',
    'III sprat',
    'IV sprat',
    'V sprat',
    ],
    tipovi: [
    'Jednokrevetna',
    'Dvokrevetna',
    'Trokrevetna',
    'Četvorokrevetna',
    'Petokrevetna'
    ],
    vrste: [
    'Muška',
    'Ženska',
    ],
    },
    editModel:{
    BrojSobe:'',
    Sprat:'',
    TipSobe:'',
    }}),

    methods: {
    validate () {
    if (this.$refs.form.validate()) {
    this.snackbar = true
    }
    },
    reset () {
    this.$refs.form.reset()
    },
    resetValidation () {
    this.$refs.form.resetValidation()
    }
    }
    }
    </script>