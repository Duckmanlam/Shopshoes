import React from "react";
import "../../scss/component/homepage/Body.scss";
import "../../scss/global.scss";

export default function Body() {
  return (
    <div className="Body">
      <div className="container">
        <div className="about-us">
          <h3 className="about-us__title">Why you Choose US</h3>
          <div className="about-us__content">
            {data?.map((item, index) => {
              return (
                <div className="about-us__item" key={index}>
                  <img className="about-us__item-icon" src={item.img} alt="" />
                  <h3 className="about-us__item-title">
                    {" "}
                    <b>{item.title}</b>
                  </h3>
                  <p className="about-us__item-description">
                    {item.description}
                  </p>
                </div>
              );
            })}
          </div>
        </div>
      </div>
    </div>
  );
}

const data = [
  {
    img: "https://lh3.googleusercontent.com/fife/AAbDypCDGgIymCccwo_juGs7PuJSQhv0MpPDIlLehK2swLEKVGaoZVP6X6LKrNpUEwjSSyHc-MepMWcHHv7Z6nDvuRg1KjgWTFQ0kYVbZIU_2yUKy9aqQauZsZmxphOVCa2gj68acoBcgP-JkcNsLaJu7VlR_5NI2_ataSXJ5g1QgTFvt3fp0U032X80pPLUNRv3NEdeujh3_eAWsMprCgaEJRoyHx9mhPi6sAGX_k3o1qKUii2lAoN1Gr7GIWwvnK_jGbFWtfrVWhpnmH7BftqkcH4be6UY94AQX5NfSbNZHCRhgVAtpz1YMW0m3Qet3QdF2CfCYVIoPXwRcZhKFjteBgGc1984ZCzwL7lQfvl0hDGy6H5m4xZw12v3XpBpoaa222SB-73Pv3vA27hOC81F6pPxzTMwvPb9hRsnD9x4w8qglNl1jlvNuxt1N5-CgBDx4Hhswc0uYAdiquk4rz9ai_CJ7o-8FM5moyaPUwYX5NhOX2fkvMRN7lV8kq6PAJEC1fQJBIdSpWGeInxuu57rXtplQAjCakBV8ON18ol8s7BXkZt0mGCYji5fs5ti5vOam9FZ5pb5BKMlZ3l_OBjGEr8f3HgnryLevGM4LUAq8CF4hoWcopxhn0Kf92bYwYhksPO_zTvFJbf0A7pr2ULbqXvF0RjdmGpkrycOZ0fZ-x5Wi8fm7hyr-658-qIGpzF2ymFV5yy_O1TjtCG2xgnvCTDH_1rbyHrZRoZCfwv6op_uDI1cApan2mKvt2M6D-d52vnulVzaD_UE2DaFxF--nh0jF5XVGsU3tYLXQR0HBr3WLIfWGXa8bm9DTvD3Kw201wsUbHUXszsHmC-OvPc9yq50HRPog25QUzLE4iZz5BAXQFJaxPXofKTFroQ8SuOQ5Q3ORl3wZ29cZlcJY6Af6K6Dw41wDzBYIzqFdcOw_CM1mIINT0IarrZ6b7F4n_V4ySm2bsoBLwCXQqf9-YB9HnAjEetAWJumdf2LnJ0EZyZtQyHTdPFGeAEgy6E1JLZQhbBsqu_5apcPBvGA85Ldi9sDvjiwergxoajQ2KayW1fdC46lOymHG5XQ7x1z7EEH4uR57109t8pfzBNLOw24XDXu9UUbTIGmaKGmr-S0zYGuYrRl47phn4I-MqIDAXOnlJhqhohZoYsQ3phecf5V6jyYSiv_wW1VlWUwYYZGY628un61gQhs0QxtrlMam6skigthzj4jZpRXGpQITFBOKHI5yOkdZv4rIa9sFe4rIUV47DzGsDhzxLEInSz4nU2V8iZi917AorC1c5iMYZqMwFpL_vVCuJWd7d97xnMeI0NX6e1t_38oHelvP0Mx1HlCiJV2B8quUDw4m1GvTrndn2vBwa5-i0Uiyn1zBymOSlGdu1M299qf0gnqfxChbrtyOIhD22otlzlIBFa2rbladeFwsBzPscagKCcH4vOs01gCTLSKQAxx3WozRoqXEOkoHqndCItWvkZYYyGbEb3fZEOoQz6HRlIQO5Q7zl0f9_x6zTcSjsLqb5S94ItOdHtQONHw_CpGLxpcIIOWikatDDFWb--3cCUXIgPHSMzy4PajEtwZ17yUyu97CgeP5bQgS0vJmPjKluJguznrI_16QbWF9mSHBVUo7DWliUdW=w1920-h942",
    title: "Free Shipping",
    description:
      "Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet. ",
  },
  {
    img: "https://lh3.googleusercontent.com/fife/AAbDypAuyR2437wvl8w3l0mXOfSmIEjwVhjaZzhD8bwvhuov8dwQIFNgJu38Jnq88984V1hvQvmgpwXr_OrpBAN9d4XkHmAvVV_a2-c2EfHJ6B58f0-SOaKcpNgSRzCXXowgd-tvrfs_hTJeDNaOyXsP7IwGEiiUj2S9GlJFBnnuet18Hfp5pRboY-a7KWmSm7iS1cvogp5H2Lz-9m0TMxoiaM_OeSTh4Uh9aegjH2W_6j3bayYmje80hukzF2anv83OJWm03SWBYinpEU4tXZTKUyD6DlSfkOc8VRUaamPHo_2c-IXYBp3AtKHnC8tBk-QTipS3AOAbVUZ_4nkiY0GJ-qbsewDDiK60xzi7ZWAwXJS0WdJIyG3f3svswW9Pe1XTgR3klwAmB8nRpgGYEkK6-xeI94tC00SSt5dFTP13N_Fi0KrWZNK1VZ5ohI-GmKJaX9NRIQgjgsByMOCN6uhZOzFRV9U2ySkGKAAuRHmsuFvhA-j03_PNUCr648cQZ5jmhQcm9m6HXbUlBdS440mrSGXRhCU0l9BGoWQUt5KY45b8BgTTJoSLSrD4WmJWGQ_Wxol4vfeafpcrBQaFH9uQKWLyf97X5h5ZcnxiukfrV4lizPuwwTB1FxVczkluB8YoNBL4StiJ1qVyX1TZ1cB8B6_I4pKkD-UUrGcNC4blevOSV0gshujK2V2HdhkXMkPaqb-xZveTPB8C3PCp4DJ-Iwwl2P0wjE14w01cP0fYEMB-I0-ANfLyXlm5Wo0nQucrRsfMkchJJjN8cLLRxf5_JfIxkjfKL6xAVKNY7mAMvnxUaBFNsWihS2_qOEpPtxtMibYBLxjL3GUEs1ZwCqlxV9O-DkLEuVcHkFmhnsF_YN2H-2Ds6mFzymmGhs_vQrhj8QDhZWdTsaTstKjzJtEYqiPRgBdnJC-Dpzra4pG8bd3pc-6rsnIjE1Lcbh473TFsqNUb3Di2TBSgMoDlBFmwlUTyVF7vRBOBgtB3F2FpNwWdHw4LLbo4TDSQAyntB10MDmhvLHRBv61KdQJuDzQ61pOYJIWPQneE_Q3Eulj--MGOD1b50O7OR_-uTZMJ7P6VhYmhmIqg_vnKXQsY9dJWEvTAnYZ9J53lNRhg36f5Epv00_H7thUBsnQrZMbLkkCQY6t8FwJhfsin333zeoBlkTpidm8ajJVPEp8Bgx95aF9ONCNNrie3RBgwuepfL09iyHXcKH_-d17hAS4PksvfBZBexf1q0LnKJU2JDiYp6q2w47F9nAboxhlSgpiEmi7tqCXjFn19hQ05nGJUIfy22LzTt-djo2AGwrDq610RJtsbo7dKAdUsvoB9N-wbH7ysPafEK7DUN_ZTMPgbthlwn9FkBEIQoiQDTTODJt5H1rIqnXVl00T3KypxlEaRe9u2eUbM66_e3IhhR4--eDXFLfEkRx2maa9DH5O9NgPqsAQWOKze4o0vFt26uJKr0i2dZ6WKbtXDjb8-ZYrCO8L6Vs5fdZ_Eik-B6rYSxOwmRdmNj5DAvbcaOTZWj8q51619uFb_4sFLk5Rb_xKq3H82hrRTixH3R0g78H3IOiKBu-DWdXjtl33Mu-ZclZ49LV7R40jaOGLy83GdOvGZQoUcIPyrzRWUztVRSfe0n4e9=w1920-h942",
    title: "100% Secure Payment",
    description:
      "Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet. ",
  },
  {
    img: "https://lh3.googleusercontent.com/fife/AAbDypACVYtDTbXfYLt_YrWCrsXKyHDWMs2lw7P8es8-nya_XrEar20TuQ81ZvUcnGg9vsoyT5v9_KD_cotDR5TLq1lhlXuMYy_9ZsjbcTg4skZbfeeYNBpUyKsVWMDz1atimfvZ0-aRRLSa83x3xgWH73iscmz6Si2w0Pu5lnm_GuVrIeUPd5GBku67Q27mks9IFoiH6UOX2ZmQoL6n_lCN-Q4ioik2OW3KZkml_uHXSb4VIF6wBUIBVW1BUPxsKGKTiM_r-141lsBr6XXx6GefgDL_ZG-QiJf-ZFAI_9yWnLeVRIoKGEmDB1hRjZ8QhXGzgNSVWXYS5dDjvJsEhRusztWOhHmOeaHEZCZGJHKYgxa6ldLKlCaYCgShT3D8uE5QOTGIAavgVaoDYYgEZGmxOM_DgB0uMRGt9i1x48rJBnHoo1hhw6L7CcVHbKjbQdNJCHttsHW1cFUlqoJkZzbFnmwtCYPg0HGd639PwHUdQ_ODvSAJNUU_Kztf6rx79ziV2xpbzA2TVkxk2APxt0PlO7LbmZsxV6uZMijAcdd0d5I7sw466FMUv6jbjaswPwt4Lwpn1AO-P6qsdRAL-SjgAjXxQOYlehLAdNWjw7S-1R0foC8OrcT2Gk0Y9bOHTgUo88pCbetQCtk9ufZKn-yXPpQi2cua1XRz8PL55hE9ZQ17BcrHOBzib_wdIiuGNs1IB2ASzL3l4yYHEtmlU7bwKCStcxXTUY5K1k7uFm8FUBJn839y5-Q-e7PEXXaixOyKWt3N-8_193R-cnRT-IOSYtusBNaW_mqupwbpKsCVcNr9DTxLoaBr84MxSLKf-qhfGUs3SrWwd9-IIiBaqqiyplQ6-hRto9eLD6-bts_73k3lXjFXnEmaflgnyruJ71bZUWA_sUWhrZkIWVyqWVsp4XPX7-rAvjAcoiOy8giafNHJgTiBOH-pA7Z_MlnU2kSmP5ZjotR9KNDuJwaTcDVdkBCG-0YfJVvHUQDbS_RbgBdciM9uNwk3I4Ad--YBDrEmyPKjoVo972zvnDf2sj4PDZULwOowDld1pYOG38YYDwWNSHfsvnxq-BrFN3g2WSLcSLIvce4LI7NmeJSCt9UnJ5uFNepJ2DjkTCYewW8Y87O92HSm1RdOqk6EOnuoNE8zo97aBDqR9ziS0V3E-_ULE6mC4ijdZW5b6GSsnpyV9lz12QNswXmlUBA5WpU66GYpPmskmv-yhwX7x0T4n0m4Pq7XXJU8tGwD_7ge8WYR6BNHGU0GoIRGCHA01lUaYzlHd8k1vDHjRE0857MjBPxkXO34_HRGAhlsEviv6haJQ_C0iRu3xq6q4RgME_w_K_L3_uOBlUsNNcgxGhIDPx7jkmmeUSqEfXD7uoR2hV9M6XJ9LMPF6tGWKzeCPFH4lFziEmeHUhOCuHakG9DDj6hvjFRttRe860441dq9KH7zMbKipCWp67IB26-Svg5wH_A5yuu1FoJKf64aFUV7bbmP7uy4iq4AXwwTgH01jhapcvqsXNUKnJMNrfHpvyC4YDZPZ27YXfcAIUijNpV7PagQMeBbL3LKf4st-tiVe8anfMhX7D3mgBsirjEvp6v7X_VDb4kP2fB7aXh5DTk-u_GIWTvrYTfQ12zhb1UtftE7=w1920-h942",
    title: "24/7 Dedicated Support",
    description:
      "Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet. ",
  },
];
