

function CarregarEndereco() {
    $(document).ready(function () {


        function limpa_formulário_cep() {
            // Limpa valores do formulário de cep.
            $("#rua").val("");
            $("#bairro").val("");
            $("#cidade").val("");
            $("#uf").val("");
            $("#ibge").val("");
        }

        //Quando o campo cep perde o foco.
        $("#cep").blur(function () {


            //Nova variável "cep" somente com dígitos.
            //var cep = $(this).val().replace(/\D/g, '');
            var cep = $(this).val();

            //Verifica se campo cep possui valor informado.
            if (cep != "") {

                //Expressão regular para validar o CEP.
                var validacep = /^[0-9]{8}$/;

                //Valida o formato do CEP.
                if (validacep.test(cep)) {

                    //Preenche os campos com "..." enquanto consulta webservice.
                    $("#rua").val("Aguarde...");
                    $("#bairro").val("Aguarde...");
                    $("#cidade").val("Aguarde...");
                    $("#uf").val("Aguarde...");
                    

                    //Consulta o webservice viacep.com.br/
                    $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                        if (!("erro" in dados)) {
                            //Atualiza os campos com os valores da consulta.
                            $("#rua").val(dados.logradouro);
                            $("#bairro").val(dados.bairro);
                            $("#cidade").val(dados.localidade);
                            $("#uf").val(dados.uf);
                            $("#ibge").val(dados.ibge);
                        } 
                        else {
                                                       limpa_formulário_cep();
                            alert("CEP não encontrado.");
                        }
                    });
                } 
                else {
           
                    limpa_formulário_cep();
                                   }
            } //end if.
            else {
                  limpa_formulário_cep();
            }
        });
    });




























}
