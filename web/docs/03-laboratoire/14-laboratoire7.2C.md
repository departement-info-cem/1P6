---
title: Trace d’exécution
---
# 🧪 Labo 7.2C – Trace d’exécution

Reprenons le code de la démonstration de la séance **7.2**

Pour rappel, lorsqu’un utilisateur clique sur le bouton **+**, l’application tente d’augmenter la température d'un objet de la classe ``Thermostat``.

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

Complétez la trace d’exécution ci-dessous en indiquant :

* les **instructions exécutées**

* **l’effet** de chaque instruction

:::tip
* Pour éviter de produire une trace trop longue, vous pouvez modifier la valeur de la constante `TEMPERATURE_DÉFAUT` :
```csharp
public const double TEMPERATURE_DÉFAUT = 34.0;
```
    Ainsi, il vous suffira d'une itération avant qu'une exception ne soit lancée.

* Pour vous aider à compléter la trace :
    * placez un **point d’arrêt** au début de ``btnAugmenter_Click()``
    * placez un **second point d’arrêt** sur la ligne :
    ```csharp
    if (value < MIN_TEMPERATURE || value > MAX_TEMPERATURE)
    ```
    
    * Exécutez ensuite le programme en utilisant le *pas à pas détaillé (F11).*
:::

# 🟡 Trace d’exécution

Complétez le tableau suivant. Pour simplifier la trace, nous allons assumer que l’application est déjà en cours d’exécution et que l’utilisateur vient de cliquer sur le bouton **+** pour augmenter la température de 34 à 35 degrés. Les 2 premières lignes de la trace vous sont fournies à titre d'exemple. 

| Code exécuté | Effet |
|---|---|
|*thermostat.augmenterTemperature();*|Appelle la méthode `augmenterTemperature()` de l'objet `thermostat`. `Temperature = 34`|
|*Temperature++;*| Tente d'augmenter la propriété `Temperature` de 1. L'opération lit d'abord la valeur actuelle (`34`), calcule `34 + 1`, puis appelle le *setter* avec ``value = 35``. `Temperature = 34`|
|||
|||
|||
|||
|||
|||
|||
|||
|*MessageBox.Show(exception.Message);*||
|lblTemperature.Text = thermostat.Temperature.ToString();||



