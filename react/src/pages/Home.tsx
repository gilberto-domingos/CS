import { Link } from "react-router-dom";
import Buttons from "../shared/components/Buttons";

export const Home = () => {
  return (
    <div>
      <h1>Bem-vindo</h1>
      <Buttons
        label="Botão Primário"
        variant="primary"
        onClick={() => alert("Primário")}
      />
      <Buttons
        label="Botão Secundário"
        variant="secondary"
        onClick={() => alert("Secundário")}
      />
      <Buttons
        label="Botão de Perigo"
        variant="danger"
        onClick={() => alert("Erro!")}
      />

      <div style={{ marginTop: "20px" }}>
        <Link to="/home2">Ir para Home2</Link>
      </div>
    </div>
  );
};
