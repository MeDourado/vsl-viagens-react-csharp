// FAQ.js

import React from "react";
import styles from "./faq.module.css";

const Faq = ({ faqData }) => {
  return (
    <div className={styles.faqContainer}>
      <div className={styles.faqList}>
        {faqData.map((faq, index) => (
          <div key={index} className={styles.faqItem}>
            <input
              type="checkbox"
              id={`question${index}`}
              className={styles.faqQuestion}
            />
            <label
              className={styles.faqQuestionLabel}
              htmlFor={`question${index}`}
            >
              {faq.question}
            </label>
            <div className={styles.faqAnswer}>
              <p>{faq.answer}</p>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default Faq;
