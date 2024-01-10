import styles from "./footer.module.css";

import Link from "next/link";

export default function Footer() {
  return (
    <footer className={styles.estilo_footer} id="footer">
      <div className={`row ${styles.estilo_secoes_footer}`}>
        <div className="col-6 col-md-2 mb-3">
          <h5>Seções</h5>
          <ul className="nav flex-column">
            <li className="nav-item mb-2">
              <Link href="/" className="nav-link p-0">
                Home
              </Link>
            </li>
            <li className="nav-item mb-2">
              <Link href="/passagens" className="nav-link p-0">
                Passagens
              </Link>
            </li>
            <li className="nav-item mb-2">
              <Link href="/contato" className="nav-link p-0">
                Contato
              </Link>
            </li>
            <li className="nav-item mb-2">
              <Link href="/login" className="nav-link p-0">
                Login
              </Link>
            </li>
          </ul>
        </div>
        <div className="col-6 col-md-2 mb-3">
          <h5>Informações </h5>

          <ul className="nav flex-column">
            <li className="nav-item mb-2">vslviagens@gmail.com</li>
            <li className="nav-item mb-2">Telefone: (00) 1234-5678</li>
            <li className="nav-item mb-2">Bairro Felicidade, 255</li>
            <li className="nav-item mb-2">Aberto das 08:00 as 19:00 </li>
          </ul>
        </div>

        <div className="col-md-5 offset-md-1 mb-3">
          <form>
            <h5>Assine nossa newsletter</h5>
            <p>Receba novidades e promoções exclusivas.</p>
            <div className="d-flex flex-column flex-sm-row w-100 gap-2">
              <label htmlFor="newsletter1" className="visually-hidden">
                Endereço de Email
              </label>
              <input
                id="newsletter1"
                type="text"
                className="form-control"
                placeholder="Endereço de Email"
              />
              <button className={`btn ${styles.estilobotao}`} type="button">
                Assinar
              </button>
            </div>
          </form>
        </div>
      </div>
      <div className={styles.estilocredito}>
        <p>
          ©
          <a href="https://www.linkedin.com/in/maria-eduarda-dourado-8a11b1186/">
            Maria Eduarda Dourado
          </a>
          - Todos os direitos reservados
        </p>
      </div>
    </footer>
  );
}
