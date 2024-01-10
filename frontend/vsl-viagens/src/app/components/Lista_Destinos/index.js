import styles from "./lista_destinos.module.css";
import Card from "../Card";

export default async function Lista_Destinos() {
  const destinos = await fetch("http://localhost:5264/api/destino").then(
    (res) => res.json()
  );

  console.log(destinos);

  return (
    <section className={styles.estilo_lista}>
      {destinos.map((destino, index) => (
        <Card key={index} data={destino} />
      ))}
    </section>
  );
}
