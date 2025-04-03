import Buttons from "../shared/components/button/Buttons";
import { useDrawerContext } from "../shared/contexts";
import "../styles/home.css";

export const Home = () => {
  const { toggleDrawerOpen } = useDrawerContext();

  return (
    <div className="home-container">
      <div className="home-button-container">
        <Buttons
          label="Alternar Tema"
          variant="secondary"
          onClick={toggleDrawerOpen}
        />
      </div>
    </div>
  );
};
