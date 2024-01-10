import styles from "./intro_section.module.css";

export default function Intro_Section() {
  return (
    <div className={`row featurette ${styles.estilo_intro_sessao}`} id="#">
      <div className={`col-md-7 ${styles.estilo_caixa_texto}`}>
        <h2 className="featurette-heading fw-normal lh-1">
          Bem-vindo à VSL Viagens!
          <span className={` ${styles.estilo_texto_especial}`}>
            Descubra o mundo conosco.
          </span>
        </h2>
        <p className="lead">
          Aqui na VSL Viagens, oferecemos experiências únicas para explorar
          destinos incríveis ao redor do mundo.
        </p>
      </div>
      <div className="col-md-5">
        <img src="./img_home.png" alt="Salvador" />
      </div>
    </div>
  );
}
