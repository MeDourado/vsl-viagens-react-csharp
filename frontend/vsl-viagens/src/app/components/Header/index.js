import Link from "next/link";
import styles from "./header.module.css";

export default function Header() {
  return (
    <>
      <header className={styles.estilo_header} id="home">
        <div className={styles.containerlogo}>
          <img src="/logo.png" alt="logo" />
        </div>

        <ul className="nav nav-pills">
          <li className="nav-item">
            <a href="#" className="nav-link">
              Home
            </a>
          </li>
          <li className="nav-item">
            <Link href="#destinos" className="nav-link">
              Destinos
            </Link>
          </li>
          <li className="nav-item">
            <Link href="#faq" className="nav-link">
              Faq
            </Link>
          </li>
          <li className="nav-item">
            <a href="#footer" className={`nav-link ${styles.link_especial}`}>
              Promoções
            </a>
          </li>
        </ul>
      </header>
    </>
  );
}
