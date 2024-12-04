package com.apivendas.venda.Models;

import java.sql.Date;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import jakarta.persistence.Temporal;
import jakarta.persistence.TemporalType;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data
@Builder
@AllArgsConstructor
@NoArgsConstructor
@Table(name = "Cliente")

public class Cliente {

    @Id
    @GeneratedValue(strategy = GenerationType.UUID)
    private Long Id;

    @Column(name = "nome", nullable = false, length = 100)
    private String nome;

    @Column(name = "email", nullable = false, length = 50, unique = true)
    private String email;

    @Column(name = "cpf", nullable = false, length = 8, unique = true)
    private String cpf;

    @Column(name = "cep", nullable = false, length = 11)
    private String cep;

    @Column(name = "rua", nullable = false, length = 50)
    private String rua;

    @Column(name = "bairro", nullable = false, length = 50)
    private String bairro;

    @Column(name = "cidade", nullable = false, length = 50)
    private String cidade;

    @Column(name = "numero", nullable = false, length = 10)
    private String numero;

    @Column(name = "complemento", nullable = true, length = 50)
    private String complemento;

    @Column(name = "telefone", nullable = false, length = 11)
    private String telefone;

    @Column(name = "senha", nullable = false, length = 50)
    private String senha;

    @Column(name = "nome_usuario", nullable = false, length = 50, unique = true)
    private String nome_usuario;

    @Temporal(TemporalType.DATE)
    @Column(name = "data_criacao", nullable = false)
    private Date data_criacao;

    @Column(name = "role", nullable = true, length = 50)
    private String role;

}
