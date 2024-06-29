<?php
if ($_SERVER['REQUEST_METHOD'] == "POST") {
    $nome = $_POST['nm_usuario'];
    $tel = $_POST['tel'];
    $email = $_POST['email'];
    $pass = $_POST['senha'];
    $pass2 = $_POST['senha2'];
    $nivel = $_POST['nivel'];

    if ($pass != $pass2) {
        header('Location: cadastrausuario.php?msg=As senhas não conferem');
        exit();
    }

    // Gerar um salt único
    $salt = md5(uniqid(rand(), true));
    $pass = md5($pass . $salt);
    include("auxiliar/conectadb.php");

    $sql = "SELECT COUNT(*) FROM tb_usuario WHERE S_MAIL_USUARIO = '$email'";
    $result = mysqli_query($link, $sql);
    $tbl = mysqli_fetch_array($result);
    $count = $tbl[0];

    if ($count != 0) {
        header('Location: cadastrausuario.php?msg=Email já cadastrado');
        exit();
    }

    // Armazenar a senha e o salt
    $sql = "INSERT INTO tb_usuario (S_NOME_USUARIO, S_PASS_USUARIO, S_SALT, S_MAIL_USUARIO, I_NIVEL_USUARIO) 
            VALUES ('$nome', '$pass', '$salt', '$email', '$nivel')";
    mysqli_query($link, $sql);
    exit();
}
?>
<?php
if ($_SERVER['REQUEST_METHOD'] == "POST") {
    include('auxiliar/conectadb.php');
    $email = $_POST['email'];
    $senha = $_POST['senha'];

    // Obter o salt armazenado para este usuário
    $sql = "SELECT S_PASS_USUARIO, S_SALT FROM tb_usuario WHERE S_MAIL_USUARIO = '$email'";
    $result = mysqli_query($link, $sql);
    if (mysqli_num_rows($result) == 0) {
        header("Location: login.php?msg=Usuário ou senha incorreto");
        exit();
    }

    $tbl = mysqli_fetch_array($result);
    $stored_password = $tbl['S_PASS_USUARIO'];
    $stored_salt = $tbl['S_SALT'];

    // Verificar a senha usando o salt armazenado
    $senha_criptografada = md5($senha . $stored_salt);
    if ($stored_password != $senha_criptografada) {
        header("Location: login.php?msg=Usuário ou senha incorreto");
        exit();
    } else {
        // Se a senha estiver correta, obtenha os dados do usuário
        $sql = "SELECT I_COD_USUARIO, S_NOME_USUARIO, I_NIVEL_USUARIO 
                FROM tb_usuario 
                WHERE S_MAIL_USUARIO = '$email' 
                AND S_PASS_USUARIO = '$senha_criptografada'";
        $result = mysqli_query($link, $sql);
        $tbl = mysqli_fetch_array($result);

        session_start();
        $_SESSION['id'] = $tbl['I_COD_USUARIO'];
        $_SESSION['nome'] = $tbl['S_NOME_USUARIO'];
        $_SESSION['nivel'] = $tbl['I_NIVEL_USUARIO'];
        header("Location: index.php");
        exit();
    }
}
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f4f4f4;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
            margin: 0;
        }
        div {
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            padding: 20px;
            width: 300px;
            text-align: center;
        }
        form {
            display: flex;
            flex-direction: column;
        }
        label {
            font-size: 14px;
            margin-bottom: 6px;
            color: #333;
        }
        input {
            padding: 8px;
            margin-bottom: 12px;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 14px;
        }
        input[type="submit"] {
            background-color: #4caf50;
            color: #fff;
            cursor: pointer;
        }
        input[type="submit"]:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <div>
        <form action="login.php" method="POST">
            <label for="email">Email:</label><br>
            <input type="email" name="email" id="email" required>
            <br>
            <label for="senha">Senha:</label><br>
            <input type="password" name="senha" id="senha" required>
            <br><br>
            <input type="submit" value="Entrar">
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
