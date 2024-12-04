package com.apivendas.venda.DTO;

import java.sql.Date;

public record ClienteDTO(Integer id, String nome, String email, String cpf, String cep, String rua, String bairro,
        String cidade, String numero, String complemento, String telefone, String senha, String nome_usuario,
        Date data_criacao, String role) {

}
