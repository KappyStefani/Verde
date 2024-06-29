<?php
include('cabecalho.php');

if ($_SERVER['REQUEST_METHOD'] == "POST") {

    $nome = $_POST['nm_usuario'];
    $tel = $_POST['tel'];
    $email = $_POST['email'];
    $pass = $_POST['senha'];
    $pass2 = $_POST['senha2'];
    $nivel = $_POST['nivel'];

    //$pass = md5(rand(0, 9999999) . "A!bmlhfpr, ,l prtg1@S#2 $ D3F4n.~g. .~mny.~yj.ñtg.bÇÇÇÇçç");

    if ($pass != $pass2) {
        header('Location: cadastrausuario.php?msg=As senhas não conferem');
        exit();
    }

    
    include("auxiliar//conectadb.php");  // conecta o banco

    $sql =
        "SELECT COUNT(*) 
    FROM tb_usuario 
    WHERE S_MAIL_USUARIO = '$email'";
    $result = mysqli_query($link, $sql);
    while ($tbl = mysqli_fetch_array($result)) {
        $count = $tbl[0];
    }

    if ($count != 0) {
        header('Location: cadastrausuario.php?msg=Email já cadastrado');
        exit();
    }


   $sql = "INSERT INTO tb_usuario (S_NOME_USUARIO, S_PASS_USUARIO, S_MAIL_USUARIO, I_NIVEL_USUARIO) VALUES ('$nome', '$pass', '$email', '$nivel')";
    mysqli_query($link, $sql);
    exit();
}

?>


<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cadastrar Usuários</title>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="stylesheet" href="auxiliar/estilo.css">
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }

        .container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 0 5px rgba(0, 0, 0, 0.2);
        }

        .form-label {
            font-weight: bold;
        }

        .form-input {
            width: 100%;
            padding: 10px;
            margin: 5px 0;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        .form-textarea {
            width: 100%;
            padding: 10px;
            margin: 5px 0;
            border: 1px solid #ccc;
            border-radius: 3px;
            resize: vertical;
        }

        .form-button {
            background-color: #4CAF50;
            color: #fff;
            border: none;
            padding: 10px 20px;
            border-radius: 3px;
            cursor: pointer;
        }

        .form-button:hover {
            background-color: #45a049;
        }

        #erro_msg {
            color: red;
            font-size: 1.2em;
            font-weight: bolder;
            padding-left: 20px;
        }

        .btn-3 {
            background: rgb(0, 172, 238);
            background: linear-gradient(0deg, rgba(0, 172, 238, 1) 0%, rgba(2, 126, 251, 1) 100%);
            width: 130px;
            height: 40px;
            line-height: 42px;
            padding: 0;
            border: none;

        }

        .btn-3 span {
            position: relative;
            display: block;
            width: 100%;
            height: 100%;
        }

        .btn-3:before,
        .btn-3:after {
            position: absolute;
            content: "";
            right: 0;
            top: 0;
            background: rgba(2, 126, 251, 1);
            transition: all 0.3s ease;
        }

        .btn-3:before {
            height: 0%;
            width: 2px;
        }

        .btn-3:after {
            width: 0%;
            height: 2px;
        }

        .btn-3:hover {
            background: transparent;
            box-shadow: none;
        }

        .btn-3:hover:before {
            height: 100%;
        }

        .btn-3:hover:after {
            width: 100%;
        }

        .btn-3 span:hover {
            color: rgba(2, 126, 251, 1);
        }

        .btn-3 span:before,
        .btn-3 span:after {
            position: absolute;
            content: "";
            left: 0;
            bottom: 0;
            background: rgba(2, 126, 251, 1);
            transition: all 0.3s ease;
        }

        .btn-3 span:before {
            width: 2px;
            height: 0%;
        }

        .btn-3 span:after {
            width: 0%;
            height: 2px;
        }

        .btn-3 span:hover:before {
            height: 100%;
        }

        .btn-3 span:hover:after {
            width: 100%;
        }
    </style>
</head>

<body>
    <div class="container">
        <h2 class="w3-center">Cadastrar Usuário</h2>
        <form class="w3-container" method="POST" action="cadastrausuario.php">
            <label for="nome" class="form-label">Nome:</label>
            <input type="text" name="nm_usuario" id="nome" maxlength="50" class="form-input">

            <label for="senha" class="form-label">Senha:</label>
            <input type="password" id="senha" name="senha" maxlength="32" class="form-input">
            <label for="senha2" class="form-label">Repita a Senha:</label>
            <input type="password" id="senha2" name="senha2" maxlength="32" class="form-input">

            <label for="tel" class="form-label">Telefone:</label>
            <input type="text" name="tel" id="tel" maxlength="14" class="form-input">

            <label for="email" class="form-label">E-mail:</label>
            <input type="email" name="email" id="email" maxlength="50" class="form-input">

            <label for="nivel" class="form-label">Nível Usuário</label>
            <select id="nivel" name="nivel" class="form-input">
                <option value="1">Cliente</option>
                <option value="10">Administrador</option>
            </select>

            <button type="submit" class="custom-btn btn-3"><span>Salvar</span></button>
            <span id="erro_msg">
                <?php
                if (isset($_GET['msg'])) {
                    echo $_GET['msg'];
                }
                ?>
            </span>
        </form>
    </div>
</body>

</html>