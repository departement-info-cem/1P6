---
title: Trace d’exécution
---
# 🧪 Labo 7.2C – Trace d’exécution

Reprenons le code développé lors de la démonstration de la séance **7.2**

Pour rappel, lorsqu’un utilisateur clique sur le bouton **+**, l’application tente d’augmenter la température d'un objet ``Thermostat``.

Considérez l'évènement suivant :

```csharp
private void btnAugmenter_Click(object sender, EventArgs e)
{
    try
    {
        thermostat.augmenterTemperature();
    }
    catch (ArgumentOutOfRangeException exception)
    {
        MessageBox.Show(exception.Message);
    }

    lblTemperature.Text = thermostat.Temperature.ToString();
}

```

La méthode appelée dans la classe ``Thermostat`` :

```csharp
public void augmenterTemperature()
{
    Temperature++;
}
```

Et l’implémentation de la propriété ``Temperature`` :

```csharp
public double Temperature
{
    get { return m_temperature; }
    private set
    {
        if (value < MIN_TEMPERATURE || value > MAX_TEMPERATURE)
            throw new ArgumentOutOfRangeException(
                "La température doit être comprise entre 5 et 35."
            );

        m_temperature = value;
    }
}
```
---
# ✏️ Travail à faire

Complétez la trace d’exécution suivante en indiquant :

* les **instructions exécutées**

* **l’effet** de chaque instruction

:::tip
* Pour éviter de produire une trace trop longue, vous pouvez modifier la valeur de la constante `MAX_TEMPERATURE` :
```csharp
public const double MAX_TEMPERATURE = 21.0;
```

* Pour vous aider à compléter la trace :
    * placez un **point d’arrêt** au début de ``btnAugmenter_Click()``
    * placez un **second point d’arrêt** sur la ligne :
    ```csharp
    if (value < MIN_TEMPERATURE || value > MAX_TEMPERATURE)
    ```
    
    * Exécutez ensuite le programme en utilisant le *pas à pas détaillé (F11).*

* Vous pouvez assumer que l’application est déjà en cours d’exécution et que l’utilisateur vient de cliquer sur le bouton **+**.

:::

# 📋 Trace d’exécution

| Code exécuté | Effet |
|---|---|
|*thermostat.augmenterTemperature();*|Appel de la méthode `augmenterTemperature()` de l'objet `thermostat`|
|*Temperature++;*| On tente de modifier la propriété `Temperature`. Le setter est appelé. ``value = 21``|
|||
|||
|||
|||
|||
|||
|||
|||
|*MessageBox.Show(exception.Message);*||



